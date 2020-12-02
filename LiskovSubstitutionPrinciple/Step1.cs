using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{

    public interface IReadableSqlFile
    {
        string LoadText();
    }

    public interface IWritebleSqlFile
    {
        void SaveText();
    }

    class SqlFile : IWritebleSqlFile, IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public string LoadText() 
        {
            return "::LoadText";
        }

        public void SaveText()
        {
            //return "::SaveText()";
        }
    }

    class SqlFileManager
    {
        public string GetTextFromFiles(List<IReadableSqlFile> aLstReadableFile)
        {
            StringBuilder objStringBuilder = new StringBuilder();

            foreach (var objFile in aLstReadableFile)
            {
                objStringBuilder.Append(objFile.LoadText());
            }
            return objStringBuilder.ToString();
        }

        public void SaveTextIntoFiles(List<IWritebleSqlFile> aLstWritebleFiles)
        {
            foreach (var objFile in aLstWritebleFiles)
            {
                if (!(objFile is ReadOnlySqlFile))
                objFile.SaveText();
            }
        }
    }

    class ReadOnlySqlFile : SqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public string LoadText()
        {
            return "Readonly.LoadText()";
        }

        public void SaveText() 
        {
            throw new InvalidOperationException("Salvare interzisă!");
        }
    }
}
