using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using SC3_pnach_editor.Services;
using System.Drawing;
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace SC3_pnach_editor.ViewModels
{
    public class CostumesViewModel : BaseViewModel
    {


        public CostumesViewModel()
        {
            SettingsClass.LoadData();
            TexturesBaseFolderPath = SettingsClass.GfxCopyFrom + @"\Skins\";
            TexturesTargetFolderPath = SettingsClass.GfxCopyTo + @"\";


            NightTerrorSkin = SettingsClass.NightTerrorSkin;
            TakiSkin = SettingsClass.TakiSkin;
            CassandraSkin = SettingsClass.CassandraSkin;
            ColossusSkin = SettingsClass.ColossusSkin;
            LynetteSkin = SettingsClass.LynetteSkin;
            NightmareSkin = SettingsClass.NightmareSkin;
            SiegfriedSkin = SettingsClass.SiegfriedSkin;
            SophitiaSkin = SettingsClass.SophitiaSkin;
            AmySkin = SettingsClass.AmySkin;
            CharadeSkin = SettingsClass.CharadeSkin;
            LizardMenSkin = SettingsClass.LizardMenSkin;
        }


        private string _texturesBaseFolderPath;
        public string TexturesBaseFolderPath
        {
            get { return _texturesBaseFolderPath; }
            set
            {
                if (_texturesBaseFolderPath != value)
                {
                    _texturesBaseFolderPath = value;
                    RaisePropertyChanged("TexturesBaseFolderPath");
                }
            }
        }

        private string _texturesTargetFolderPath;
        public string TexturesTargetFolderPath
        {
            get { return _texturesTargetFolderPath; }
            set
            {
                if (_texturesTargetFolderPath != value)
                {
                    _texturesTargetFolderPath = value;
                    RaisePropertyChanged("TexturesTargetFolderPath");
                }
            }
        }
        
        private string _skinPreview;
        public string SkinPreview
        {
            get { return _skinPreview; }
            set
            {
                if (_skinPreview != value)
                {
                    _skinPreview = value;
                    RaisePropertyChanged("SkinPreview");
                }
            }
        }


        private string _nightTerrorSkin;

        public string NightTerrorSkin
        {
            get { return _nightTerrorSkin; }
            set
            {
                if (_nightTerrorSkin != value)
                {
                    _nightTerrorSkin = value;
                    SettingsClass.NightTerrorSkin = _nightTerrorSkin;
                    RaisePropertyChanged("NightTerrorSkin");
                }
            }
        }

        private string _takiSkin;

        public string TakiSkin
        {
            get { return _takiSkin; }
            set
            {
                if (_takiSkin != value)
                {
                    _takiSkin = value;
                    SettingsClass.TakiSkin = _takiSkin;
                    RaisePropertyChanged("TakiSkin");
                }
            }
        }

        private string _cassandraSkin;

        public string CassandraSkin
        {
            get { return _cassandraSkin; }
            set
            {
                if (_cassandraSkin != value)
                {
                    _cassandraSkin = value;
                    SettingsClass.CassandraSkin = _cassandraSkin;
                    RaisePropertyChanged("CassandraSkin");
                }
            }
        }

        private string _colossusSkin;

        public string ColossusSkin
        {
            get { return _colossusSkin; }
            set
            {
                if (_colossusSkin != value)
                {
                    _colossusSkin = value;
                    SettingsClass.ColossusSkin = _colossusSkin;
                    RaisePropertyChanged("ColossusSkin");
                }
            }
        }

        private string _lynetteSkin;

        public string LynetteSkin
        {
            get { return _lynetteSkin; }
            set
            {
                if (_lynetteSkin != value)
                {
                    _lynetteSkin = value;
                    SettingsClass.LynetteSkin = _lynetteSkin;
                    RaisePropertyChanged("LynetteSkin");
                }
            }
        }

        private string _nightmareSkin;

        public string NightmareSkin
        {
            get { return _nightmareSkin; }
            set
            {
                if (_nightmareSkin != value)
                {
                    _nightmareSkin = value;
                    SettingsClass.NightmareSkin = _nightmareSkin;
                    RaisePropertyChanged("NightmareSkin");
                }
            }
        }

        private string _siegfriedSkin;

        public string SiegfriedSkin
        {
            get { return _siegfriedSkin; }
            set
            {
                if (_siegfriedSkin != value)
                {
                    _siegfriedSkin = value;
                    SettingsClass.SiegfriedSkin = _siegfriedSkin;
                    RaisePropertyChanged("SiegfriedSkin");
                }
            }
        }

        private string _sophitiaSkin;

        public string SophitiaSkin
        {
            get { return _sophitiaSkin; }
            set
            {
                if (_sophitiaSkin != value)
                {
                    _sophitiaSkin = value;
                    SettingsClass.SophitiaSkin = _sophitiaSkin;
                    RaisePropertyChanged("SophitiaSkin");
                }
            }
        }

        private string _amySkin;

        public string AmySkin
        {
            get { return _amySkin; }
            set
            {
                if (_amySkin != value)
                {
                    _amySkin = value;
                    SettingsClass.AmySkin = _amySkin;
                    RaisePropertyChanged("AmySkin");
                }
            }
        }

        private string _charadeSkin;

        public string CharadeSkin
        {
            get { return _charadeSkin; }
            set
            {
                if (_charadeSkin != value)
                {
                    _charadeSkin = value;
                    SettingsClass.CharadeSkin = _charadeSkin;
                    RaisePropertyChanged("CharadeSkin");
                }
            }
        }

        private string _lizardMenSkin;

        public string LizardMenSkin
        {
            get { return _lizardMenSkin; }
            set
            {
                if (_lizardMenSkin != value)
                {
                    _lizardMenSkin = value;
                    SettingsClass.LizardMenSkin = _lizardMenSkin;
                    RaisePropertyChanged("LizardMenSkin");
                }
            }
        }


        private string _errorTextMessage;

        public string ErrorTextMessage
        {
            get { return _errorTextMessage; }
            set
            {
                if (_errorTextMessage != value)
                {
                    _errorTextMessage = value;
                    RaisePropertyChanged("ErrorTextMessage");
                }
            }
        }
        

        public void AddOrRemoveTextures(string type, string texture)
        {
            try
            {
                ReplaceTexturesPack(texture, type);
            }
            catch (Exception error)
            {
                ErrorTextMessage = error.Message;
            }

            SettingsClass.SaveData();

        }

        internal void ReplaceTexturesPack(string folderName, string type)
        {
            string copyFrom = TexturesBaseFolderPath + folderName;
            string copyTo = TexturesTargetFolderPath + folderName;
            if (type == "add")
            {
                if (Directory.Exists(copyTo))
                {
                    Directory.Delete(copyTo, true);
                }

                CopyDirectory(copyFrom, copyTo);
            }
            else if (type == "remove")
            {
                DeleteFolder(copyTo);
            }

        }


        static void CopyDirectory(string sourceDir, string destinationDir)
        {
            // Create the destination directory if it does not exist
            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }

            // Copy all files in the source directory
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = System.IO.Path.Combine(destinationDir, System.IO.Path.GetFileName(file));
                File.Copy(file, destFile, true); // true allows overwriting
            }

            // Recursively copy subdirectories
            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string destSubDir = System.IO.Path.Combine(destinationDir, System.IO.Path.GetFileName(subDir));
                CopyDirectory(subDir, destSubDir);
            }
        }

        static void DeleteFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                // Remove Read-Only Attribute from All Files
                foreach (string file in Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories))
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                }

                // Delete the folder and its contents
                Directory.Delete(folderPath, true);
            }
        }

        internal void ReplaceTextures(string folderName, string name1, string name2, string name3, string name4, string name5, string name6,
            string name7, string name8, string name9,string name10, string name11, string name12, string name13, string name14, string name15,
            string name16, string name17, string name18, string name19, string name20, string name21, string name22, string name23, string name24,
            string name25, string name26, string name27, string name28, string name29, string name30)
        {
            if (name1 != "")
            {
                string file1 = TexturesBaseFolderPath + folderName + name1 + ".png";
                string file1Path = TexturesTargetFolderPath + @"\" + name1 + ".png";
                File.Delete(file1Path);
                File.Copy(file1, file1Path);
            }
            if (name2 != "")
            {
                string file2 = TexturesBaseFolderPath + folderName + name2 + ".png";
                string file2Path = TexturesTargetFolderPath + @"\" + name2 + ".png";
                File.Delete(file2Path);
                File.Copy(file2, file2Path);
            }
            if (name3 != "")
            {
                string file3 = TexturesBaseFolderPath + folderName + name3 + ".png";
                string file3Path = TexturesTargetFolderPath + @"\" + name3 + ".png";
                File.Delete(file3Path);
                File.Copy(file3, file3Path);
            }
            if (name4 != "")
            {
                string file4 = TexturesBaseFolderPath + folderName + name4 + ".png";
                string file4Path = TexturesTargetFolderPath + @"\" + name4 + ".png";
                File.Delete(file4Path);
                File.Copy(file4, file4Path);
            }
            if (name5 != "")
            {
                string file5 = TexturesBaseFolderPath + folderName + name5 + ".png";
                string file5Path = TexturesTargetFolderPath + @"\" + name5 + ".png";
                File.Delete(file5Path);
                File.Copy(file5, file5Path);
            }
            if (name6 != "")
            {
                string file6 = TexturesBaseFolderPath + folderName + name6 + ".png";
                string file6Path = TexturesTargetFolderPath + @"\" + name6 + ".png";
                File.Delete(file6Path);
                File.Copy(file6, file6Path);
            }
            if (name7 != "")
            {
                string file7 = TexturesBaseFolderPath + folderName + name7 + ".png";
                string file7Path = TexturesTargetFolderPath + @"\" + name7 + ".png";
                File.Delete(file7Path);
                File.Copy(file7, file7Path);
            }
            if (name8 != "")
            {
                string file8 = TexturesBaseFolderPath + folderName + name8 + ".png";
                string file8Path = TexturesTargetFolderPath + @"\" + name8 + ".png";
                File.Delete(file8Path);
                File.Copy(file8, file8Path);
            }
            if (name9 != "")
            {
                string file9 = TexturesBaseFolderPath + folderName + name9 + ".png";
                string file9Path = TexturesTargetFolderPath + @"\" + name9 + ".png";
                File.Delete(file9Path);
                File.Copy(file9, file9Path);
            }
            if (name10 != "")
            {
                string file10 = TexturesBaseFolderPath + folderName + name10 + ".png";
                string file10Path = TexturesTargetFolderPath + @"\" + name10 + ".png";
                File.Delete(file10Path);
                File.Copy(file10, file10Path);
            }
            if (name11 != "")
            {
                string file11 = TexturesBaseFolderPath + folderName + name11 + ".png";
                string file11Path = TexturesTargetFolderPath + @"\" + name11 + ".png";
                File.Delete(file11Path);
                File.Copy(file11, file11Path);
            }
            if (name12 != "")
            {
                string file12 = TexturesBaseFolderPath + folderName + name12 + ".png";
                string file12Path = TexturesTargetFolderPath + @"\" + name12 + ".png";
                File.Delete(file12Path);
                File.Copy(file12, file12Path);
            }
            if (name13 != "")
            {
                string file13 = TexturesBaseFolderPath + folderName + name13 + ".png";
                string file13Path = TexturesTargetFolderPath + @"\" + name13 + ".png";
                File.Delete(file13Path);
                File.Copy(file13, file13Path);
            }
            if (name14 != "")
            {
                string file14 = TexturesBaseFolderPath + folderName + name14 + ".png";
                string file14Path = TexturesTargetFolderPath + @"\" + name14 + ".png";
                File.Delete(file14Path);
                File.Copy(file14, file14Path);
            }
            if (name15 != "")
            {
                string file15 = TexturesBaseFolderPath + folderName + name15 + ".png";
                string file15Path = TexturesTargetFolderPath + @"\" + name15 + ".png";
                File.Delete(file15Path);
                File.Copy(file15, file15Path);
            }
            if (name16 != "")
            {
                string file16 = TexturesBaseFolderPath + folderName + name16 + ".png";
                string file16Path = TexturesTargetFolderPath + @"\" + name16 + ".png";
                File.Delete(file16Path);
                File.Copy(file16, file16Path);
            }
            if (name17 != "")
            {
                string file17 = TexturesBaseFolderPath + folderName + name17 + ".png";
                string file17Path = TexturesTargetFolderPath + @"\" + name17 + ".png";
                File.Delete(file17Path);
                File.Copy(file17, file17Path);
            }
            if (name18 != "")
            {
                string file18 = TexturesBaseFolderPath + folderName + name18 + ".png";
                string file18Path = TexturesTargetFolderPath + @"\" + name18 + ".png";
                File.Delete(file18Path);
                File.Copy(file18, file18Path);
            }
            if (name19 != "")
            {
                string file19 = TexturesBaseFolderPath + folderName + name19 + ".png";
                string file19Path = TexturesTargetFolderPath + @"\" + name19 + ".png";
                File.Delete(file19Path);
                File.Copy(file19, file19Path);
            }
            if (name20 != "")
            {
                string file20 = TexturesBaseFolderPath + folderName + name20 + ".png";
                string file20Path = TexturesTargetFolderPath + @"\" + name20 + ".png";
                File.Delete(file20Path);
                File.Copy(file20, file20Path);
            }
            if (name21 != "")
            {
                string file21 = TexturesBaseFolderPath + folderName + name21 + ".png";
                string file21Path = TexturesTargetFolderPath + @"\" + name21 + ".png";
                File.Delete(file21Path);
                File.Copy(file21, file21Path);
            }
            if (name22 != "")
            {
                string file22 = TexturesBaseFolderPath + folderName + name22 + ".png";
                string file22Path = TexturesTargetFolderPath + @"\" + name22 + ".png";
                File.Delete(file22Path);
                File.Copy(file22, file22Path);
            }
            if (name23 != "")
            {
                string file23 = TexturesBaseFolderPath + folderName + name23 + ".png";
                string file23Path = TexturesTargetFolderPath + @"\" + name23 + ".png";
                File.Delete(file23Path);
                File.Copy(file23, file23Path);
            }
            if (name24 != "")
            {
                string file24 = TexturesBaseFolderPath + folderName + name24 + ".png";
                string file24Path = TexturesTargetFolderPath + @"\" + name24 + ".png";
                File.Delete(file24Path);
                File.Copy(file24, file24Path);
            }
            if (name25 != "")
            {
                string file25 = TexturesBaseFolderPath + folderName + name25 + ".png";
                string file25Path = TexturesTargetFolderPath + @"\" + name25 + ".png";
                File.Delete(file25Path);
                File.Copy(file25, file25Path);
            }
            if (name26 != "")
            {
                string file26 = TexturesBaseFolderPath + folderName + name26 + ".png";
                string file26Path = TexturesTargetFolderPath + @"\" + name26 + ".png";
                File.Delete(file26Path);
                File.Copy(file26, file26Path);
            }
            if (name17 != "")
            {
                string file27 = TexturesBaseFolderPath + folderName + name27 + ".png";
                string file27Path = TexturesTargetFolderPath + @"\" + name27 + ".png";
                File.Delete(file27Path);
                File.Copy(file27, file27Path);
            }
            if (name28 != "")
            {
                string file28 = TexturesBaseFolderPath + folderName + name28 + ".png";
                string file28Path = TexturesTargetFolderPath + @"\" + name28 + ".png";
                File.Delete(file28Path);
                File.Copy(file28, file28Path);
            }
            if (name29 != "")
            {
                string file29 = TexturesBaseFolderPath + folderName + name29 + ".png";
                string file29Path = TexturesTargetFolderPath + @"\" + name29 + ".png";
                File.Delete(file29Path);
                File.Copy(file29, file29Path);
            }
            if (name30 != "")
            {
                string file30 = TexturesBaseFolderPath + folderName + name30 + ".png";
                string file30Path = TexturesTargetFolderPath + @"\" + name30 + ".png";
                File.Delete(file30Path);
                File.Copy(file30, file30Path);
            }
        }

        internal void RemoveTextures(string name1, string name2, string name3, string name4, string name5, string name6, string name7, string name8,
            string name9, string name10, string name11, string name12, string name13, string name14, string name15, string name16, string name17,
            string name18, string name19, string name20, string name21, string name22, string name23, string name24, string name25, string name26,
            string name27, string name28, string name29, string name30)
        {

            File.Delete(TexturesTargetFolderPath + @"\" + name1 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name2 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name3 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name4 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name5 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name6 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name7 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name8 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name9 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name10 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name11 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name12 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name13 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name14 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name15 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name16 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name17 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name18 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name19 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name20 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name21 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name22 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name23 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name24 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name25 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name26 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name27 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name28 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name29 + ".png");
            File.Delete(TexturesTargetFolderPath + @"\" + name30 + ".png");
        }

    }
}
