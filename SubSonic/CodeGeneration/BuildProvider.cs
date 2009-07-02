/*
 * SubSonic - http://subsonicproject.com
 * 
 * The contents of this file are subject to the Mozilla Public
 * License Version 1.1 (the "License"); you may not use this file
 * except in compliance with the License. You may obtain a copy of
 * the License at http://www.mozilla.org/MPL/
 * 
 * Software distributed under the License is distributed on an 
 * "AS IS" basis, WITHOUT WARRANTY OF ANY KIND, either express or
 * implied. See the License for the specific language governing
 * rights and limitations under the License.
*/

using System;
using System.CodeDom;
using System.IO;
using System.Text;
using System.Web.Compilation;
using System.Web.Hosting;
using SubSonic.Utilities;

namespace SubSonic
{
    /// <summary>
    /// Summary for the BuildProvider class
    /// </summary>
    public class BuildProvider : System.Web.Compilation.BuildProvider
    {
        /// <summary>
        /// Generates source code for the virtual path of the build provider, and adds the source code to a specified assembly builder.
        /// </summary>
        /// <param name="assemblyBuilder">The assembly builder that references the source code generated by the build provider.</param>
        public override void GenerateCode(AssemblyBuilder assemblyBuilder)
        {
            Utility.WriteTrace("Invoking BuildProvider");
            DataService.LoadProviders();
            ICodeLanguage language = new CSharpCodeLanguage();

            DirectoryInfo di = new DirectoryInfo(HostingEnvironment.ApplicationPhysicalPath + "\\App_Code");
            FileInfo[] fi = di.GetFiles("*.vb");
            if(fi.Length > 0)
                language = new VBCodeLanguage();

            StringBuilder code = new StringBuilder(language.DefaultUsingStatements);
            TurboCompiler tc = new TurboCompiler();

            // loop over the providers, and generate code for each
            foreach(DataProvider provider in DataService.Providers)
            {
                Utility.WriteTrace(String.Format("Creating code for {0}", provider.Name));
                string[] tableList = DataService.GetTableNames(provider.Name);
                string[] viewList = DataService.GetViewNames(provider.Name);

                foreach(string tbl in tableList)
                {
                    TurboTemplate tt = CodeService.BuildClassTemplate(tbl, language, provider);
                    tc.AddTemplate(tt);
                    if(provider.GenerateODSControllers)
                    {
                        TurboTemplate tODS = CodeService.BuildODSTemplate(tbl, language, provider);
                        tc.AddTemplate(tODS);
                    }
                }

                foreach(string view in viewList)
                {
                    TurboTemplate tt = CodeService.BuildViewTemplate(view, language, provider);
                    tc.AddTemplate(tt);
                }

                tc.AddTemplate(CodeService.BuildSPTemplate(language, provider));
            }

            if(DataService.Providers.Count > 0)
                tc.AddTemplate(CodeService.BuildStructsTemplate(language, DataService.Provider));

            foreach(TurboTemplate tt in tc.Templates)
                tt.AddUsingBlock = false;
            tc.Run();

            foreach(TurboTemplate tt in tc.Templates)
                code.Append(tt.FinalCode);

            assemblyBuilder.AddCodeCompileUnit(this, new CodeSnippetCompileUnit(code.ToString()));
        }
    }
}