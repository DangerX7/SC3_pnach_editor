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

namespace SC3_pnach_editor.ViewModels
{
    public class CostumesViewModel : BaseViewModel
    {


        public CostumesViewModel()
        {
            SettingsClass.LoadData();
            TexturesBaseFolderPath = SettingsClass.GfxCopyFrom + @"\Skins\";
            TexturesTargetFolderPath = SettingsClass.GfxCopyTo;


            NightTerrorSkin = SettingsClass.NightTerrorSkin;
            TakiSkin = SettingsClass.TakiSkin;
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
            switch (texture)
            {
                case "nightTerrorGraySkin":
                    if (type == "add")
                    {
                        try
                        {
                            ReplaceTextures(@"\Alt_Night_Terror\", "17cddcb346c641cd-ada04c386efd6795-r128x64-00002a93", "2fff2ed54477c1d3-6056cb63b00a0647-r128x64-00002a93",
                                "316280873e353249-8d323311f476a595-r128x128-00002a93", "3603054d75453b05-2d8d8ab83fbcc793-r128x128-00002a93",
                                "42314a5dd1c7f075-c23b5ebf48131e12-r128x64-00002a93", "4f6bc098125a5228-cdccc5b8dec7d1fc-r256x256-00002a93",
                                "5c5066374b76adff-6cc9c703b29e7917-r128x64-00002a93", "b0d87eac4974ca36-833265533a9e52ea-r64x64-00002a93",
                                "b5e68bd6cdea370-4ddb4c27940de88e-r128x128-00002a93", "b5f5479c33e28297-d184ded7f0465b28-r128x64-00002a93",
                                "b829d72ac4ade1d8-b6b9f32feff88a77-r256x128-00002a93", "c8bc8e96984c6a33-d38f1b4efadbb0b6-r128x64-00002a93",
                                "cdf9359b89487c53-534e96e98ae3fd43-r128x64-00002a93", "e84877f8a964231b-2cbe83cbedb970ee-r128x64-00002a93",
                                "ed6862f967d5ba9f-e2deae24a16386ff-r256x256-00002a93", "f15135d4f7d6870c-630a0ebe48de4c59-r128x128-00002a93",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "");

                            SettingsClass.NightTerrorSkin = NightTerrorSkin;
                            SettingsClass.SaveData();
                        }
                        catch (Exception error)
                        {
                            ErrorTextMessage = error.Message;
                        }
                    }
                    else if (type == "remove")
                    {
                        RemoveTextures("17cddcb346c641cd-ada04c386efd6795-r128x64-00002a93", "2fff2ed54477c1d3-6056cb63b00a0647-r128x64-00002a93",
                                "316280873e353249-8d323311f476a595-r128x128-00002a93", "3603054d75453b05-2d8d8ab83fbcc793-r128x128-00002a93",
                                "42314a5dd1c7f075-c23b5ebf48131e12-r128x64-00002a93", "4f6bc098125a5228-cdccc5b8dec7d1fc-r256x256-00002a93",
                                "5c5066374b76adff-6cc9c703b29e7917-r128x64-00002a93", "b0d87eac4974ca36-833265533a9e52ea-r64x64-00002a93",
                                "b5e68bd6cdea370-4ddb4c27940de88e-r128x128-00002a93", "b5f5479c33e28297-d184ded7f0465b28-r128x64-00002a93",
                                "b829d72ac4ade1d8-b6b9f32feff88a77-r256x128-00002a93", "c8bc8e96984c6a33-d38f1b4efadbb0b6-r128x64-00002a93",
                                "cdf9359b89487c53-534e96e98ae3fd43-r128x64-00002a93", "e84877f8a964231b-2cbe83cbedb970ee-r128x64-00002a93",
                                "ed6862f967d5ba9f-e2deae24a16386ff-r256x256-00002a93", "f15135d4f7d6870c-630a0ebe48de4c59-r128x128-00002a93",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "");
                    }
                    break;
                case "takiStockingsSkin":
                    if (type == "add")
                    {
                        try
                        {
                            ReplaceTextures(@"\Taki_Blue\", "2056eac81651761f-94ec922ae8a628dc-r128x128-00002a93", "a0718f3b4f3e195b-f20a75b232183a9d-r64x64-00002a93",
                                "ec1eb3472b8fb398-20ffa0116b34e0be-r128x128-00002a93", "f3fd9af293c7fa58-a110ceda0ec48026-r256x256-00002a93",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "");

                            SettingsClass.TakiSkin = TakiSkin;
                            SettingsClass.SaveData();
                        }
                        catch (Exception error)
                        {
                            ErrorTextMessage = error.Message;
                        }
                    }
                    else if (type == "remove")
                    {
                        RemoveTextures("2056eac81651761f-94ec922ae8a628dc-r128x128-00002a93", "a0718f3b4f3e195b-f20a75b232183a9d-r64x64-00002a93",
                                "ec1eb3472b8fb398-20ffa0116b34e0be-r128x128-00002a93", "f3fd9af293c7fa58-a110ceda0ec48026-r256x256-00002a93",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "",
                                "", "");
                    }
                    break;
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
