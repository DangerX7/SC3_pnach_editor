using SC3_pnach_editor.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC3_pnach_editor.Codes
{
    public class NewWeapons
    {
        public static string GetWeaponsCode(bool on, bool customWpnEffectsP1, bool customWpnEffectsP2)
        {
            string weaponsCode = "";

            if (SettingsClass.GfxCopyFrom != "" && SettingsClass.GfxCopyTo != "")
            {
                if (on)
                {
                    if (!customWpnEffectsP1 || !customWpnEffectsP2)
                    {
                        //Copy Graphics
                        string copyFrom = SettingsClass.GfxCopyFrom + @"\Ultimate_Weapons\";
                        string copyTo = SettingsClass.GfxCopyTo;

                        //check if files are already there, just the one image is enough
                        string proveImage = @"" + copyTo + "\\3d500480bb6417c2-b2a513a0ca309da4-r128x64-00002a94.png";

                        // Check if the file exists
                        if (File.Exists(proveImage))
                        {
                            //Don't Copy
                        }
                        else
                        {
                            //Copy Ultimate Weapons
                            // Check if the directory exists before attempting to delete it
                            if (Directory.Exists(copyTo))
                            {
                                // Delete the folder and all its contents
                                Directory.Delete(copyTo, true);
                            }

                            // Recreate the folder
                            Directory.CreateDirectory(copyTo);

                            List<string> imgFiles = new List<string>();
                            imgFiles.Add("1c64d3aa1bc9a60a-4c7cfe8cb8c03635-r40000000400000-00006a94" + ".png");
                            imgFiles.Add("1f557f570a429bac-4124de58142ba734-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("2ac893da1a7deac2-93ed2d70083439ce-r20000000400000-00006a94" + ".png");
                            imgFiles.Add("2c6a06922462ea65-565f3ec802227427-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("3a567f50d280d416-d54a31ca7fd53ada-r20000000800000-00006a94" + ".png");
                            imgFiles.Add("3ad911ffd252fe93-1e5e2fef90169b3e-r40000000800000-00006a94" + ".png");
                            imgFiles.Add("3d500480bb6417c2-b2a513a0ca309da4-r128x64-00002a94" + ".png");
                            imgFiles.Add("3e096412b90c73e9-ff1f434a6f56911-r40000000400000-00006a93" + ".png");
                            imgFiles.Add("4b3bbe50eca579af-55778e2a33bcef70-r40000000400000-00006a93" + ".png");
                            imgFiles.Add("4ef11ab3dfd2b78d-28dfd86425c2d3e8-r20000000400000-00006a94" + ".png");
                            imgFiles.Add("5c60f74acc4bf44-5d414374ca402b3-r20000000400000-00006a94" + ".png");
                            imgFiles.Add("5d26c11024549522-a3d009a6b3f1c4a9-r80000000800000-00006a93" + ".png");
                            imgFiles.Add("5eabafdf4c4d95fc-98017c1e73a66c44-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("8b1ff1feadfef2d-a3ee5ae7f34e4319-r10000000800000-00006a94" + ".png");
                            imgFiles.Add("8c88920ecb2fcdd-cf1a362d5d41442d-r20000000200000-00006a94" + ".png");
                            imgFiles.Add("8f9ece2325498121-983c288820b4f9ed-r80000001000000-00006a93" + ".png");
                            imgFiles.Add("9ad2ff669b6af87b-59b9344f047ba64f-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("9d7e2d2a595467a2-fb1d2a686cc53745-r20000000400000-00006a94" + ".png");
                            imgFiles.Add("16efac4cc3e395cc-3161707a0c587bc5-r80000000800000-00006a93" + ".png");
                            imgFiles.Add("18e0a0ffaa03b15a-93b46543e92130b1-r40000001000000-00006a93" + ".png");
                            imgFiles.Add("31ccf9d7da32411a-c37fba12f5a9e630-r20000000400000-00006a94" + ".png");
                            imgFiles.Add("36e4f541a6966d55-f8a76016fe0b7054-r20000000800000-00006a93" + ".png");
                            imgFiles.Add("37ca665f3aaa1db1-eee6f89f3038860d-r80000001000000-00006a93" + ".png");
                            imgFiles.Add("38fb799055e06e5b-489017cce8583b69-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("39d0e9ef0c3a5412-8a8159d51e6bcf0e-r40000000800000-00006a94" + ".png");
                            imgFiles.Add("46c95966ec3e99e0-e2892b5861d97cc5-r40000000400000-00006a93" + ".png");
                            imgFiles.Add("53a184a8aa328aea-a559d328ec210f9f-rc0000001000000-00006a93" + ".png");
                            imgFiles.Add("64abfb5a94a12c1b-f4e65768e9df2ece-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("66c73d2afaadfd3b-461d1cab48b6028c-r40000001000000-00006a93" + ".png");
                            imgFiles.Add("69b87377a5e43199-54b79693f59c2410-r40000001000000-00006a93" + ".png");
                            imgFiles.Add("78d0bc402ec08f68-b423f6ccfa58b40c-r40000000800000-00006a94" + ".png");
                            imgFiles.Add("82d380f2cc095481-1298c52af7363c69-r20000000200000-00006a94" + ".png");
                            imgFiles.Add("92fc6be139a39e7b-23b3f92f9d8d86f0-r40000000200000-00006a94" + ".png");
                            imgFiles.Add("93e5d9feb1cd22e9-289680d3ba9c2838-r20000000400000-00006a93" + ".png");
                            imgFiles.Add("95bcfe4c3d1e42bd-b8571fe876d17dae-r40000001000000-00006a93" + ".png");
                            imgFiles.Add("233e812974d6d643-f3662c493aaa5011-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("329fbdd4b76ebe5-1fb9502eb182fa67-r80000000800000-00006a93" + ".png");
                            imgFiles.Add("349b5a49dc143006-e7838913f847dc32-r80000000800000-00006a94" + ".png");
                            imgFiles.Add("450f43d66c2d4143-afd5c1084379f3eb-r20000000800000-00006a93" + ".png");
                            imgFiles.Add("504f7fbe04bb6c1a-9cc61fb008fa7f0b-r80000000800000-00006a94" + ".png");
                            imgFiles.Add("739bc9a2d83cc4d7-925646cba5fc8451-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("831eacb302721cc-d2ded17b542c8f09-r20000000400000-00006a94" + ".png");
                            imgFiles.Add("1428ce481be15e8c-14e4e53bf56cc53-r40000000200000-00006a94" + ".png");
                            imgFiles.Add("1899a0927f0b3ca3-f186a9c2834d855-r40000000400000-00006a93" + ".png");
                            imgFiles.Add("3352d27fd69319b3-9e9b1a22abcf82ca-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("3589e1c458eb4544-9d846f91b4386128-r40000000600000-00006a94" + ".png");
                            imgFiles.Add("4302a284b73453c6-b3479d6fca8e1bca-r80000000c00000-00006a93" + ".png");
                            imgFiles.Add("5675f99db4a66b9f-7263ed6906c4d7bb-r40000000400000-00006a93" + ".png");
                            imgFiles.Add("5753ba83bea9a256-bb016c1a061c4af1-r20000000600000-00006a94" + ".png");
                            imgFiles.Add("23390d13c070f785-c6452c661152e5ba-r40000000400000-00006a93" + ".png");
                            imgFiles.Add("48212fc626c907e3-00006a80" + ".png");
                            imgFiles.Add("81492f7724600a03-9b43420391d307f2-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("85970c67afe1027c-6f63e3994515f2a0-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("88114a74140de574-24d3c6077fa5bf26-r20000000800000-00006a93" + ".png");
                            imgFiles.Add("446333ff5118fc1-1f08f3e0d158ba5b-r80000001000000-00006a93" + ".png");
                            imgFiles.Add("676975d011299d9c-4c0ae6e4f3da51e9-r40000000400000-00006a94" + ".png");
                            imgFiles.Add("740939affa669250-a4b48049ce2112e0-r20000000400000-00006a94" + ".png");
                            imgFiles.Add("769269ec4a7fd042-bc84f34b809f549c-r20000000200000-00006a94" + ".png");
                            imgFiles.Add("6108192cd6ec7133-c1a2f3c1c63e88cd-r20000000800000-00006a94" + ".png");
                            imgFiles.Add("8178516b9d45df20-e60441199b65740b-r40000000800000-00006a94" + ".png");
                            imgFiles.Add("121620558cd903b0-7cc5042158e15384-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("5033610921ce463d-9be3ff843a15b885-r80000001000000-00006a93" + ".png");
                            imgFiles.Add("a25f1fa9e494c11e-7fab8a3ccb07d4e2-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("a77a04daef66d6f6-r64x32-00002a80" + ".png");
                            imgFiles.Add("a0669e5723b139d6-e885a387d194fbfe-r40000000400000-00006a94" + ".png");
                            imgFiles.Add("ac5dbfe006dce9e9-170b653e6d24db3b-r64x8-00002a94" + ".png");
                            imgFiles.Add("ad139e67dff5c7bb-78ad4a9ec1032d25-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("b1ba80a3611d3b94-90268c4376495e7a-r10000000200000-00006a94" + ".png");
                            imgFiles.Add("b33e152728a16fb7-f8d436aaa6be62eb-r20000000400000-00006a94" + ".png");
                            imgFiles.Add("b88bf7eb80fa1767-8902317b0db1f469-r10000000800000-00006a94" + ".png");
                            imgFiles.Add("b0103d215051b9bc-316c0d2db4fef775-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("bb0be0c030c6a863-b4b53285d3f81e3b-r40000000400000-00006a93" + ".png");
                            imgFiles.Add("be2028f04bc3337d-cd82c6530fd706f6-r20000000800000-00006a93" + ".png");
                            imgFiles.Add("c551daa6a596f75b-46ab2e6cecabe200-r20000000800000-00006a93" + ".png");
                            imgFiles.Add("c833c5385796461c-bcfdf87d4b84ea18-r20000000800000-00006a94" + ".png");
                            imgFiles.Add("c9013acbd79899d5-dad01135263b978a-r80000000800000-00006a93" + ".png");
                            imgFiles.Add("cd5c9f5b6e3d6a64-c98d4a18e6f93598-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("cddaa61732252a3d-1737f1751029ad38-r40000000800000-00006a94" + ".png");
                            imgFiles.Add("ce3d1eb29731f1cd-3c505a7aec8e31af-r60000000800000-00006a93" + ".png");
                            imgFiles.Add("d8ce8ac6785d78eb-bd644ae80b8021d6-r20000000800000-00006a93" + ".png");
                            imgFiles.Add("d73df27e973e1ec4-8455e818caa1e8a3-r80000000200000-00006a93" + ".png");
                            imgFiles.Add("d4413ddb969152a3-7f429020278d715e-r40000000400000-00006a94" + ".png");
                            imgFiles.Add("d20410ed5a81cec7-9ccf718d325bb34-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("e2ceca0c3b2fa824-fb4d9ffb5b4529b2-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("e6ef4ab1922ca4da-c889878577ef4cf3-r40000000400000-00006a94" + ".png");
                            imgFiles.Add("e9cd5af5eca4ca8d-dcaec120fc4c852d-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("e59f08f0b1d943bf-bcc1c7f8c16b69f2-r40000000400000-00006a94" + ".png");
                            imgFiles.Add("e647a4bfaf105eb5-bd3148a1c220575f-r40000000400000-00006a94" + ".png");
                            imgFiles.Add("e09295c934fea1fb-80685e8cf5b9a27d-r40000000800000-00006a93" + ".png");
                            imgFiles.Add("f63fd07359e73bad-a1fb5ec983bff1e8-r20000000400000-00006a93" + ".png");
                            imgFiles.Add("f81f6d86912746ac-29d40aa43dfbadb2-r20000000800000-00006a93" + ".png");
                            imgFiles.Add("f3050edde479c697-97a89259cf611516-r40000000400000-00006a94" + ".png");
                            imgFiles.Add("f139411520f723d0-b508126ae1ed0529-r80000000800000-00006a94" + ".png");
                            imgFiles.Add("fb64acb81e5479cc-194a3f328e0a30c4-r40000000400000-00006a93" + ".png");
                            imgFiles.Add("feec291d5c699fe-65a0886b036b4ee-r20000000200000-00006a94" + ".png");

                            foreach (var img in imgFiles)
                            {
                                string copyFromLocation = copyFrom + @"\" + img;
                                string copyToLocation = copyTo + @"\" + img;
                                File.Copy(copyFromLocation, copyToLocation);
                            }
                        }

                        //Copy Text
                        weaponsCode += "\n" +
                            "patch=1,EE,20B7C292,extended,6C755400 //Mitsurugi Weapons Name    \n" +
                            "patch=1,EE,20B7C296,extended,00726177 //Mitsurugi Weapons Name    \n" +
                            "patch=1,EE,20B7C29A,extended,00000000 //Mitsurugi Weapons Name    \n" +
                            "patch=1,EE,20B7C2F2,extended,626D4100 //Seong-Mina Weapons Name    \n" +
                            "patch=1,EE,20B7C2F6,extended,61737361 //Seong-Mina Weapons Name    \n" +
                            "patch=1,EE,20B7C2FA,extended,00726F64 //Seong-Mina Weapons Name    \n" +
                            "patch=1,EE,20B7C362,extended,6C695300 //Taki Weapons Name    \n" +
                            "patch=1,EE,20B7C366,extended,20746E65 //Taki Weapons Name    \n" +
                            "patch=1,EE,20B7C36A,extended,65676445 //Taki Weapons Name    \n" +
                            "patch=1,EE,20B7C3B6,extended,6B617942 //Maxi Weapons Name    \n" +
                            "patch=1,EE,20B7C3BA,extended,00006F6B //Maxi Weapons Name    \n" +
                            "patch=1,EE,20B7C3BE,extended,00000000 //Maxi Weapons Name    \n" +
                            "patch=1,EE,20B7C418,extended,6D72614B //Voldo Weapons Name    \n" +
                            "patch=1,EE,20B7C41C,extended,20262061 //Voldo Weapons Name    \n" +
                            "patch=1,EE,20B7C420,extended,6172614D //Voldo Weapons Name    \n" +
                            "patch=1,EE,20B7C48C,extended,726F7753 //Sophitia Weapons Name    \n" +
                            "patch=1,EE,20B7C490,extended,65726264 //Sophitia Weapons Name    \n" +
                            "patch=1,EE,20B7C494,extended,72656B61 //Sophitia Weapons Name    \n" +
                            "patch=1,EE,20B7C4D6,extended,65745300 //Siegfried Weapons Name    \n" +
                            "patch=1,EE,20B7C4DA,extended,42206C65 //Siegfried Weapons Name    \n" +
                            "patch=1,EE,20B7C4DE,extended,6564616C //Siegfried Weapons Name    \n" +
                            "patch=1,EE,20B7C52A,extended,6E726F4D //Rock Weapons Name    \n" +
                            "patch=1,EE,20B7C52E,extended,20676E69 //Rock Weapons Name    \n" +
                            "patch=1,EE,20B7C532,extended,72617453 //Rock Weapons Name    \n" +
                            "patch=1,EE,20B7C58C,extended,6172694D //Ivy Weapons Name    \n" +
                            "patch=1,EE,20B7C590,extended,42206567 //Ivy Weapons Name    \n" +
                            "patch=1,EE,20B7C594,extended,6564616C //Ivy Weapons Name    \n" +
                            "patch=1,EE,20B7C5EA,extended,7473614D //Kilik Weapons Name    \n" +
                            "patch=1,EE,20B7C5EE,extended,20737265 //Kilik Weapons Name    \n" +
                            "patch=1,EE,20B7C5F2,extended,66617453 //Kilik Weapons Name    \n" +
                            "patch=1,EE,20B7C5F6,extended,6F4E0066 //Kilik Weapons Name    \n" +
                            "patch=1,EE,20B7C640,extended,7469724B //Xianghua Weapons Name    \n" +
                            "patch=1,EE,20B7C644,extended,75592D61 //Xianghua Weapons Name    \n" +
                            "patch=1,EE,20B7C648,extended,00006167 //Xianghua Weapons Name    \n" +
                            "patch=1,EE,20B7C6A6,extended,6F724900 //Lizardman Weapons Name    \n" +
                            "patch=1,EE,20B7C6AA,extended,6148206E //Lizardman Weapons Name    \n" +
                            "patch=1,EE,20B7C6AE,extended,65686374 //Lizardman Weapons Name    \n" +
                            "patch=1,EE,20B7C6B2,extended,59000074 //Lizardman Weapons Name    \n" +
                            "patch=1,EE,20B7C700,extended,73794D00 //Yoshimitsu Weapons Name    \n" +
                            "patch=1,EE,20B7C704,extended,20636974 //Yoshimitsu Weapons Name    \n" +
                            "patch=1,EE,20B7C708,extended,6867694E //Yoshimitsu Weapons Name    \n" +
                            "patch=1,EE,20B7C70C,extended,53000074 //Yoshimitsu Weapons Name    \n" +
                            "patch=1,EE,20B7C780,extended,6E616947 //Nightmare Weapons Name    \n" +
                            "patch=1,EE,20B7C784,extended,6C532074 //Nightmare Weapons Name    \n" +
                            "patch=1,EE,20B7C788,extended,72657961 //Nightmare Weapons Name    \n" +
                            "patch=1,EE,20B7C7D4,extended,6C754200 //Astaroth Weapons Name    \n" +
                            "patch=1,EE,20B7C7D8,extended,0061766F //Astaroth Weapons Name    \n" +
                            "patch=1,EE,20B7C7DC,extended,00000000 //Astaroth Weapons Name    \n" +
                            "patch=1,EE,20B7C844,extended,61726946 //Cervantes Weapons Name    \n" +
                            "patch=1,EE,20B7C848,extended,0069676E //Cervantes Weapons Name    \n" +
                            "patch=1,EE,20B7C84C,extended,00000000 //Cervantes Weapons Name    \n" +
                            "patch=1,EE,20B7C88E,extended,716E6943 //Raphael Weapons Name    \n" +
                            "patch=1,EE,20B7C892,extended,65646575 //Raphael Weapons Name    \n" +
                            "patch=1,EE,20B7C896,extended,00000061 //Raphael Weapons Name    \n" +
                            "patch=1,EE,20B7C904,extended,6E695700 //Talim Weapons Name    \n" +
                            "patch=1,EE,20B7C908,extended,75472064 //Talim Weapons Name    \n" +
                            "patch=1,EE,20B7C90C,extended,00656469 //Talim Weapons Name    \n" +
                            "patch=1,EE,20B7C98C,extended,7A74614B //Cassandra Weapons Name    \n" +
                            "patch=1,EE,20B7C990,extended,676C6162 //Cassandra Weapons Name    \n" +
                            "patch=1,EE,20B7C994,extended,00007265 //Cassandra Weapons Name    \n" +
                            "patch=1,EE,20B7C9F0,extended,6E61684B //Yun-Seong Weapons Name    \n" +
                            "patch=1,EE,20B7C9F4,extended,0072696A //Yun-Seong Weapons Name    \n" +
                            "patch=1,EE,20B7C9F8,extended,00000000 //Yun-Seong Weapons Name    \n" +
                            "patch=1,EE,20B7CA64,extended,72754B00 //Setsuka Weapons Name    \n" +
                            "patch=1,EE,20B7CA68,extended,6E61686F //Setsuka Weapons Name    \n" +
                            "patch=1,EE,20B7CA6C,extended,00000061 //Setsuka Weapons Name    \n" +
                            "patch=1,EE,20B7CAA2,extended,6E616854 //Zasalamel Weapons Name    \n" +
                            "patch=1,EE,20B7CAA6,extended,736F7461 //Zasalamel Weapons Name    \n" +
                            "patch=1,EE,20B7CAAA,extended,00000000 //Zasalamel Weapons Name    \n" +
                            "patch=1,EE,20B7CAF8,extended,6F6F6C42 //Tira Weapons Name    \n" +
                            "patch=1,EE,20B7CAFC,extended,6F4D2064 //Tira Weapons Name    \n" +
                            "patch=1,EE,20B7CB00,extended,00006E6F //Tira Weapons Name    \n" +
                            "patch=1,EE,20B7CB54,extended,20656854 //Olcadan Weapons Name    \n" +
                            "patch=1,EE,20B7CB58,extended,69746C55 //Olcadan Weapons Name    \n" +
                            "patch=1,EE,20B7CB5C,extended,6574616D //Olcadan Weapons Name    \n" +
                            " \n";

                    }

                    //Copy Effects
                    if (!customWpnEffectsP1)
                    {
                        weaponsCode += "\n" +
                            "patch=1,EE,D04B4862,extended,04000001 //if P1 is using Mitsurugi style        \n" +
                            "patch=1,EE,D04B4896,extended,03000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3FA80000 //Decrease/Increase Attack        \n" +
                            "patch=1,EE,204B4C58,extended,3F800000 //Increase Damage Received by Opponent when successfully Guard Impact          \n" +
                            "patch=1,EE,204B4C6C,extended,3D400000 //Drain/Recover Health over Time         \n" +
                            "patch=1,EE,D04B4862,extended,04000002 //if P1 is using Seong Mi-na style        \n" +
                            "patch=1,EE,D04B4896,extended,03000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C3C,extended,3F400000 //Damage inflicted thru guard      \n" +
                            "patch=1,EE,204B4C40,extended,3FAE0000 //Weapon Size      \n" +
                            "patch=1,EE,204B4C6C,extended,BD200000 //Drain/Recover Health when Attacking    \n" +
                            "patch=1,EE,D04B4862,extended,06000003 //if P1 is using Taki style        \n" +
                            "patch=1,EE,D04B4896,extended,05000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3F840000 //Decrease/Increase Attack     \n" +
                            "patch=1,EE,204B4C40,extended,3F900000 //Weapon Size       \n" +
                            "patch=1,EE,204B4C44,extended,3F700000 //Decrease/Increase Attack Pushback Force       \n" +
                            "patch=1,EE,204B4C60,extended,40000000 //Increase Guard Break Chance       \n" +
                            "patch=1,EE,204B4C70,extended,BFC00000 //Drain/Recover Health when Attacking      \n" +
                            "patch=1,EE,D04B4862,extended,08000004 //if P1 is using Maxi style        \n" +
                            "patch=1,EE,D04B4896,extended,07000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3F900000 //Decrease/Increase Attack     \n" +
                            "patch=1,EE,204B4C34,extended,3F480000 //Decrease/Increase Defense     \n" +
                            "patch=1,EE,204B4C38,extended,3EC00000 //Steal health from enemy    \n" +
                            "patch=1,EE,204B4C40,extended,3F840000 //Weapon Size    \n" +
                            "patch=1,EE,204B4C4C,extended,40000000 //Nullify Enemies Counters chance   \n" +
                            "patch=1,EE,204B4C50,extended,3D800000 //Decrease/Increase Health while guarding enemies attacks     \n" +
                            "patch=1,EE,204B4C60,extended,3F800000 //Increase Guard Break Chance     \n" +
                            "patch=1,EE,D04B4862,extended,07000005 //if P1 is using Voldo style        \n" +
                            "patch=1,EE,D04B4896,extended,06000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3F500000 //Decrease/Increase Attack     \n" +
                            "patch=1,EE,204B4C34,extended,3F300000 //Decrease/Increase Defense     \n" +
                            "patch=1,EE,204B4C38,extended,BF000000 //Steal health from enemy    \n" +
                            "patch=1,EE,204B4C50,extended,3EB00000 //Decrease/Increase Health while guarding enemies attacks     \n" +
                            "patch=1,EE,204B4C5C,extended,BF000000 //Recover Health when successfully Guard Impact    \n" +
                            "patch=1,EE,204B4C70,extended,C0800000 //Drain/Recover Health when Attacking    \n" +
                            "patch=1,EE,D04B4862,extended,04000006 //if P1 is using Sophitia style        \n" +
                            "patch=1,EE,D04B4896,extended,03000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3FF00000 //Decrease/Increase Attack       \n" +
                            "patch=1,EE,204B4C34,extended,3F400000 //Decrease/Increase Defense     \n" +
                            "patch=1,EE,204B4C38,extended,3E500000 //Steal health from enemy    \n" +
                            "patch=1,EE,D04B4862,extended,03000007 //if P1 is using Siegfried style        \n" +
                            "patch=1,EE,D04B4896,extended,02000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3FE00000 //Decrease/Increase Attack     \n" +
                            "patch=1,EE,204B4C60,extended,3F000000 //Increase Guard Break Chance   \n" +
                            "patch=1,EE,D04B4862,extended,08000008 //if P1 is using Rock style        \n" +
                            "patch=1,EE,D04B4896,extended,07000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3FB00000 //Decrease/Increase Attack      \n" +
                            "patch=1,EE,204B4C40,extended,3F900000 //Weapon Size   \n" +
                            "patch=1,EE,204B4C3C,extended,3E000000 //Damage inflicted thru guard    \n" +
                            "patch=1,EE,204B4C44,extended,3FB00000 //Decrease/Increase Attack Pushback Force   \n" +
                            "patch=1,EE,204B4C50,extended,3E000000 //Decrease/Increase Health while guarding enemies attacks     \n" +
                            "patch=1,EE,204B4C60,extended,3E000000 //Increase Guard Break Chance   \n" +
                            "patch=1,EE,204B4C6C,extended,3C800000 //Drain/Recover Health over Time   \n" +
                            "patch=1,EE,D04B4862,extended,0800000B //if P1 is using Ivy style        \n" +
                            "patch=1,EE,D04B4896,extended,07000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C2C,extended,00100000 //Increase attack over time     \n" +
                            "patch=1,EE,204B4C34,extended,3F700000 //Decrease/Increase Defense     \n" +
                            "patch=1,EE,204B4C40,extended,3F900000 //Weapon Size    \n" +
                            "patch=1,EE,204B4C44,extended,3F900000 //Decrease/Increase Attack Pushback Force    \n" +
                            "patch=1,EE,204B4C64,extended,3F800000 //Increase Throw Escape Rate    \n" +
                            "patch=1,EE,204B4C68,extended,3F800000 //Increase Ring-Out Escape Rate     \n" +
                            "patch=1,EE,204B4C6C,extended,3D600000 //Drain/Recover Health over Time   \n" +
                            "patch=1,EE,D04B4862,extended,0600000C //if P1 is using Kilik style        \n" +
                            "patch=1,EE,D04B4896,extended,05000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3FC80000 //Decrease/Increase Attack   \n" +
                            "patch=1,EE,204B4C34,extended,3F480000 //Decrease/Increase Defense    \n" +
                            "patch=1,EE,204B4C40,extended,3F900000 //Weapon Size     \n" +
                            "patch=1,EE,204B4C54,extended,3DCCCCCB //Automatically Guard Impact some attacks   \n" +
                            "patch=1,EE,204B4C60,extended,3E800000 //Increase Guard Break Chance   \n" +
                            "patch=1,EE,D04B4862,extended,0500000D //if P1 is using Xianghua style        \n" +
                            "patch=1,EE,D04B4896,extended,04000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C3C,extended,3E000000 //Damage inflicted thru guard   \n" +
                            "patch=1,EE,204B4C44,extended,3F400000 //Decrease/Increase Attack Pushback Force   \n" +
                            "patch=1,EE,204B4C64,extended,3F400000 //Increase Throw Escape Rate   \n" +
                            "patch=1,EE,204B4C6C,extended,3D800000 //Drain/Recover Health over Time  \n" +
                            "patch=1,EE,D04B4862,extended,0800000E //if P1 is using Lizardman style        \n" +
                            "patch=1,EE,D04B4896,extended,07000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3F820000 //Decrease/Increase Attack   \n" +
                            "patch=1,EE,204B4C34,extended,3F000000 //Decrease/Increase Defense   \n" +
                            "patch=1,EE,204B4C38,extended,3F100000 //Steal health from enemy   \n" +
                            "patch=1,EE,204B4C3C,extended,3E700000 //Damage inflicted thru guard  \n" +
                            "patch=1,EE,204B4C40,extended,3F8A0000 //Weapon Size   \n" +
                            "patch=1,EE,204B4C5C,extended,3F000000 //Recover Health when successfully Guard Impact  \n" +
                            "patch=1,EE,204B4C64,extended,3F000000 //Increase Throw Escape Rate   \n" +
                            "patch=1,EE,D04B4862,extended,0800000F //if P1 is using Yoshimitsu style        \n" +
                            "patch=1,EE,D04B4896,extended,07000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C2C,extended,00100000 //Increase attack over time  \n" +
                            "patch=1,EE,204B4C30,extended,3FA00000 //Decrease/Increase Attack  \n" +
                            "patch=1,EE,204B4C34,extended,3F700000 //Decrease/Increase Defense   \n" +
                            "patch=1,EE,204B4C3C,extended,3D000000 //Damage inflicted thru guard   \n" +
                            "patch=1,EE,204B4C40,extended,3F880000 //Weapon Size   \n" +
                            "patch=1,EE,204B4C68,extended,3F000000 //Increase Ring-Out Escape Rate  \n" +
                            "patch=1,EE,204B4C6C,extended,3D400000 //Drain/Recover Health over Time  \n" +
                            "patch=1,EE,D04B4862,extended,06000011 //if P1 is using Nightmare style        \n" +
                            "patch=1,EE,D04B4896,extended,05000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3F820000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204B4C40,extended,3FA00000 //Weapon Size \n" +
                            "patch=1,EE,204B4C44,extended,3FAE0000 //Decrease/Increase Attack Pushback Force  \n" +
                            "patch=1,EE,204B4C6C,extended,3D000000 //Drain/Recover Health over Time  \n" +
                            "patch=1,EE,204B4C70,extended,BFC00000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04B4862,extended,04000012 //if P1 is using Astaroth style        \n" +
                            "patch=1,EE,D04B4896,extended,03000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3FE00000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204B4C3C,extended,3F000000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,204B4C70,extended,41000000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04B4862,extended,08000014 //if P1 is using Cervantes style        \n" +
                            "patch=1,EE,D04B4896,extended,07000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C34,extended,3F600000 //Decrease/Increase Defense \n" +
                            "patch=1,EE,204B4C3C,extended,3E200000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,204B4C44,extended,3F700000 //Decrease/Increase Attack Pushback Force \n" +
                            "patch=1,EE,204B4C58,extended,3F000000 //Increase Damage Received by Opponent when successfully Guard Impact \n" +
                            "patch=1,EE,204B4C60,extended,3F000000 //Increase Guard Break Chance \n" +
                            "patch=1,EE,204B4C6C,extended,3D200000 //Drain/Recover Health over Time \n" +
                            "patch=1,EE,204B4C70,extended,C0000000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04B4862,extended,03000015 //if P1 is using Raphael style        \n" +
                            "patch=1,EE,D04B4896,extended,02000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3FA00000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204B4C3C,extended,40000000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,D04B4862,extended,05000016 //if P1 is using Talim style        \n" +
                            "patch=1,EE,D04B4896,extended,04000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3FA80000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204B4C40,extended,3F8E0000 //Weapon Size \n" +
                            "patch=1,EE,204B4C60,extended,3F000000 //Increase Guard Break Chance \n" +
                            "patch=1,EE,204B4C70,extended,C1200000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04B4862,extended,0D000017 //if P1 is using Cassandra style        \n" +
                            "patch=1,EE,D04B4896,extended,0C000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C2C,extended,00200000 //Guard Impact becomes easier to perform \n" +
                            "patch=1,EE,204B4C34,extended,3F600000 //Decrease/Increase Defense \n" +
                            "patch=1,EE,204B4C48,extended,40000000 //Increase Counter Chance \n" +
                            "patch=1,EE,204B4C4C,extended,40000000 //Nullify Enemies Counters chance \n" +
                            "patch=1,EE,204B4C50,extended,3D800000 //Decrease/Increase Health while guarding enemies attacks \n" +
                            "patch=1,EE,204B4C54,extended,3DCCCCCB //Automatically Guard Impact some attacks \n" +
                            "patch=1,EE,204B4C58,extended,3E800000 //Increase Damage Received by Opponent when successfully Guard Impact \n" +
                            "patch=1,EE,204B4C5C,extended,3E000000 //Recover Health when successfully Guard Impact \n" +
                            "patch=1,EE,204B4C60,extended,3D800000 //Increase Guard Break Chance \n" +
                            "patch=1,EE,204B4C64,extended,40000000 //Increase Throw Escape Rate \n" +
                            "patch=1,EE,204B4C68,extended,40000000 //Increase Ring-Out Escape Rate \n" +
                            "patch=1,EE,204B4C70,extended,C0C00000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04B4862,extended,0800001A //if P1 is using Yun-Seong style        \n" +
                            "patch=1,EE,D04B4896,extended,07C00007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3FA00000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204B4C3C,extended,3E900000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,204B4C40,extended,3F780000 //Weapon Size \n" +
                            "patch=1,EE,204B4C50,extended,3D800000 //Decrease/Increase Health while guarding enemies attacks \n" +
                            "patch=1,EE,204B4C60,extended,3F000000 //Increase Guard Break Chance \n" +
                            "patch=1,EE,204B4C6C,extended,3C800000 //Drain/Recover Health over Time \n" +
                            "patch=1,EE,204B4C70,extended,C0800000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04B4862,extended,07000022 //if P1 is using Setsuka style        \n" +
                            "patch=1,EE,D04B4896,extended,06000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C2C,extended,00200000 //Guard Impact becomes easier to perform \n" +
                            "patch=1,EE,204B4C30,extended,3FC00000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204B4C54,extended,00000000 //Automatically Guard Impact some attacks \n" +
                            "patch=1,EE,204B4C58,extended,40000000 //Increase Damage Received by Opponent when successfully Guard Impact \n" +
                            "patch=1,EE,204B4C5C,extended,40000000 //Recover Health when successfully Guard Impact \n" +
                            "patch=1,EE,204B4C6C,extended,3C800000 //Drain/Recover Health over Time \n" +
                            "patch=1,EE,D04B4862,extended,05000023 //if P1 is using Tira style        \n" +
                            "patch=1,EE,D04B4896,extended,04000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C38,extended,40000000 //Steal health from enemy \n" +
                            "patch=1,EE,204B4C40,extended,3F900000 //Weapon Size \n" +
                            "patch=1,EE,204B4C3C,extended,3E800000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,204B4C70,extended,40600000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04B4862,extended,06000024 //if P1 is using Zasalamel style        \n" +
                            "patch=1,EE,D04B4896,extended,05000007 //if P1 is using ultimate weapon        \n" +
                            "patch=1,EE,204B4C30,extended,3FB40000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204B4C38,extended,3F200000 //Steal health from enemy \n" +
                            "patch=1,EE,204B4C3C,extended,3E900000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,204B4C40,extended,3F900000 //Weapon Size \n" +
                            "patch=1,EE,204B4C6C,extended,BD800000 //Drain/Recover Health over Time \n" +
                            " \n";
                    }
                    if (!customWpnEffectsP2)
                    {
                        weaponsCode += "\n" +
                            "patch=1,EE,D04D1FE2,extended,04000001 //if P2 is using Mitsurugi style        \n" +
                            "patch=1,EE,D04D2016,extended,03000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3FA80000 //Decrease/Increase Attack        \n" +
                            "patch=1,EE,204D23D8,extended,3F800000 //Increase Damage Received by Opponent when successfully Guard Impact          \n" +
                            "patch=1,EE,204D23EC,extended,3D400000 //Drain/Recover Health over Time         \n" +
                            "patch=1,EE,D04D1FE2,extended,04000002 //if P2 is using Seong Mi-na style        \n" +
                            "patch=1,EE,D04D2016,extended,03000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23BC,extended,3F400000 //Damage inflicted thru guard      \n" +
                            "patch=1,EE,204D23C0,extended,3FAE0000 //Weapon Size      \n" +
                            "patch=1,EE,204D23EC,extended,BD200000 //Drain/Recover Health when Attacking    \n" +
                            "patch=1,EE,D04D1FE2,extended,06000003 //if P2 is using Taki style        \n" +
                            "patch=1,EE,D04D2016,extended,05000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3F840000 //Decrease/Increase Attack     \n" +
                            "patch=1,EE,204D23C0,extended,3F900000 //Weapon Size       \n" +
                            "patch=1,EE,204D23C4,extended,3F700000 //Decrease/Increase Attack Pushback Force       \n" +
                            "patch=1,EE,204D23E0,extended,40000000 //Increase Guard Break Chance       \n" +
                            "patch=1,EE,204D23F0,extended,BFC00000 //Drain/Recover Health when Attacking      \n" +
                            "patch=1,EE,D04D1FE2,extended,08000004 //if P2 is using Maxi style        \n" +
                            "patch=1,EE,D04D2016,extended,07000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3F900000 //Decrease/Increase Attack     \n" +
                            "patch=1,EE,204D23B4,extended,3F480000 //Decrease/Increase Defense     \n" +
                            "patch=1,EE,204D23B8,extended,3EC00000 //Steal health from enemy    \n" +
                            "patch=1,EE,204D23C0,extended,3F840000 //Weapon Size    \n" +
                            "patch=1,EE,204D23CC,extended,40000000 //Nullify Enemies Counters chance   \n" +
                            "patch=1,EE,204D23D0,extended,3D800000 //Decrease/Increase Health while guarding enemies attacks     \n" +
                            "patch=1,EE,204D23E0,extended,3F800000 //Increase Guard Break Chance     \n" +
                            "patch=1,EE,D04D1FE2,extended,07000005 //if P2 is using Voldo style        \n" +
                            "patch=1,EE,D04D2016,extended,06000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3F500000 //Decrease/Increase Attack     \n" +
                            "patch=1,EE,204D23B4,extended,3F300000 //Decrease/Increase Defense     \n" +
                            "patch=1,EE,204D23B8,extended,BF000000 //Steal health from enemy    \n" +
                            "patch=1,EE,204D23D0,extended,3EB00000 //Decrease/Increase Health while guarding enemies attacks     \n" +
                            "patch=1,EE,204D23DC,extended,BF000000 //Recover Health when successfully Guard Impact    \n" +
                            "patch=1,EE,204D23F0,extended,C0800000 //Drain/Recover Health when Attacking    \n" +
                            "patch=1,EE,D04D1FE2,extended,04000006 //if P2 is using Sophitia style        \n" +
                            "patch=1,EE,D04D2016,extended,03000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3FF00000 //Decrease/Increase Attack       \n" +
                            "patch=1,EE,204D23B4,extended,3F400000 //Decrease/Increase Defense     \n" +
                            "patch=1,EE,204D23B8,extended,3E500000 //Steal health from enemy    \n" +
                            "patch=1,EE,D04D1FE2,extended,03000007 //if P2 is using Siegfried style        \n" +
                            "patch=1,EE,D04D2016,extended,02000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3FE00000 //Decrease/Increase Attack     \n" +
                            "patch=1,EE,204D23E0,extended,3F000000 //Increase Guard Break Chance   \n" +
                            "patch=1,EE,D04D1FE2,extended,08000008 //if P2 is using Rock style        \n" +
                            "patch=1,EE,D04D2016,extended,07000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3FB00000 //Decrease/Increase Attack      \n" +
                            "patch=1,EE,204D23C0,extended,3F900000 //Weapon Size   \n" +
                            "patch=1,EE,204D23BC,extended,3E000000 //Damage inflicted thru guard    \n" +
                            "patch=1,EE,204D23C4,extended,3FB00000 //Decrease/Increase Attack Pushback Force   \n" +
                            "patch=1,EE,204D23D0,extended,3EB00000 //Decrease/Increase Health while guarding enemies attacks     \n" +
                            "patch=1,EE,204D23E0,extended,3E000000 //Increase Guard Break Chance   \n" +
                            "patch=1,EE,204D23EC,extended,3C800000 //Drain/Recover Health over Time   \n" +
                            "patch=1,EE,D04D1FE2,extended,0800000B //if P2 is using Ivy style        \n" +
                            "patch=1,EE,D04D2016,extended,07000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23AC,extended,00100000 //Increase attack over time     \n" +
                            "patch=1,EE,204D23B4,extended,3F700000 //Decrease/Increase Defense     \n" +
                            "patch=1,EE,204D23C0,extended,3F900000 //Weapon Size    \n" +
                            "patch=1,EE,204D23C4,extended,3F900000 //Decrease/Increase Attack Pushback Force    \n" +
                            "patch=1,EE,204D23E4,extended,3F800000 //Increase Throw Escape Rate    \n" +
                            "patch=1,EE,204D23E8,extended,3F800000 //Increase Ring-Out Escape Rate     \n" +
                            "patch=1,EE,204D23EC,extended,3D600000 //Drain/Recover Health over Time   \n" +
                            "patch=1,EE,D04D1FE2,extended,0600000C //if P2 is using Kilik style        \n" +
                            "patch=1,EE,D04D2016,extended,05000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3FC80000 //Decrease/Increase Attack   \n" +
                            "patch=1,EE,204D23B4,extended,3F480000 //Decrease/Increase Defense    \n" +
                            "patch=1,EE,204D23C0,extended,3F900000 //Weapon Size     \n" +
                            "patch=1,EE,204D23D4,extended,3DCCCCCB //Automatically Guard Impact some attacks   \n" +
                            "patch=1,EE,204D23E0,extended,3E800000 //Increase Guard Break Chance   \n" +
                            "patch=1,EE,D04D1FE2,extended,0500000D //if P2 is using Xianghua style        \n" +
                            "patch=1,EE,D04D2016,extended,04000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23BC,extended,3E000000 //Damage inflicted thru guard   \n" +
                            "patch=1,EE,204D23C4,extended,3F400000 //Decrease/Increase Attack Pushback Force   \n" +
                            "patch=1,EE,204D23E4,extended,3F400000 //Increase Throw Escape Rate   \n" +
                            "patch=1,EE,204D23EC,extended,3D800000 //Drain/Recover Health over Time  \n" +
                            "patch=1,EE,D04D1FE2,extended,0800000E //if P2 is using Lizardman style        \n" +
                            "patch=1,EE,D04D2016,extended,07000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3F820000 //Decrease/Increase Attack   \n" +
                            "patch=1,EE,204D23B4,extended,3F000000 //Decrease/Increase Defense   \n" +
                            "patch=1,EE,204D23B8,extended,3F100000 //Steal health from enemy   \n" +
                            "patch=1,EE,204D23BC,extended,3E700000 //Damage inflicted thru guard  \n" +
                            "patch=1,EE,204D23C0,extended,3F8A0000 //Weapon Size   \n" +
                            "patch=1,EE,204D23DC,extended,3F000000 //Recover Health when successfully Guard Impact  \n" +
                            "patch=1,EE,204D23E4,extended,3F000000 //Increase Throw Escape Rate   \n" +
                            "patch=1,EE,D04D1FE2,extended,0800000F //if P2 is using Yoshimitsu style        \n" +
                            "patch=1,EE,D04D2016,extended,07000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23AC,extended,00100000 //Increase attack over time  \n" +
                            "patch=1,EE,204D23B0,extended,3FA00000 //Decrease/Increase Attack  \n" +
                            "patch=1,EE,204D23B4,extended,3F700000 //Decrease/Increase Defense   \n" +
                            "patch=1,EE,204D23BC,extended,3D000000 //Damage inflicted thru guard   \n" +
                            "patch=1,EE,204D23C0,extended,3F880000 //Weapon Size   \n" +
                            "patch=1,EE,204D23E8,extended,3F000000 //Increase Ring-Out Escape Rate  \n" +
                            "patch=1,EE,204D23EC,extended,3D400000 //Drain/Recover Health over Time  \n" +
                            "patch=1,EE,D04D1FE2,extended,06000011 //if P2 is using Nightmare style        \n" +
                            "patch=1,EE,D04D2016,extended,05000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3F820000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204D23C0,extended,3FA00000 //Weapon Size \n" +
                            "patch=1,EE,204D23C4,extended,3FAE0000 //Decrease/Increase Attack Pushback Force  \n" +
                            "patch=1,EE,204D23EC,extended,3D000000 //Drain/Recover Health over Time  \n" +
                            "patch=1,EE,204D23F0,extended,BFC00000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04D1FE2,extended,04000012 //if P2 is using Astaroth style        \n" +
                            "patch=1,EE,D04D2016,extended,03000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3FE00000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204D23BC,extended,3F000000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,204D23F0,extended,41000000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04D1FE2,extended,08000014 //if P2 is using Cervantes style        \n" +
                            "patch=1,EE,D04D2016,extended,07000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B4,extended,3F600000 //Decrease/Increase Defense \n" +
                            "patch=1,EE,204D23BC,extended,3E200000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,204D23C4,extended,3F700000 //Decrease/Increase Attack Pushback Force \n" +
                            "patch=1,EE,204D23D8,extended,3F000000 //Increase Damage Received by Opponent when successfully Guard Impact \n" +
                            "patch=1,EE,204D23E0,extended,3F000000 //Increase Guard Break Chance \n" +
                            "patch=1,EE,204D23EC,extended,3D200000 //Drain/Recover Health over Time \n" +
                            "patch=1,EE,204D23F0,extended,C0000000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04D1FE2,extended,03000015 //if P2 is using Raphael style        \n" +
                            "patch=1,EE,D04D2016,extended,02000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3FA00000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204D23BC,extended,40000000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,D04D1FE2,extended,05000016 //if P2 is using Talim style        \n" +
                            "patch=1,EE,D04D2016,extended,04000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3FA80000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204D23C0,extended,3F8E0000 //Weapon Size \n" +
                            "patch=1,EE,204D23E0,extended,3F000000 //Increase Guard Break Chance \n" +
                            "patch=1,EE,204D23F0,extended,C1200000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04D1FE2,extended,0D000017 //if P2 is using Cassandra style        \n" +
                            "patch=1,EE,D04D2016,extended,0C000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23AC,extended,00200000 //Guard Impact becomes easier to perform \n" +
                            "patch=1,EE,204D23B4,extended,3F600000 //Decrease/Increase Defense \n" +
                            "patch=1,EE,204D23C8,extended,40000000 //Increase Counter Chance \n" +
                            "patch=1,EE,204D23CC,extended,40000000 //Nullify Enemies Counters chance \n" +
                            "patch=1,EE,204D23D0,extended,3D800000 //Decrease/Increase Health while guarding enemies attacks \n" +
                            "patch=1,EE,204D23D4,extended,3DCCCCCB //Automatically Guard Impact some attacks \n" +
                            "patch=1,EE,204D23D8,extended,3E800000 //Increase Damage Received by Opponent when successfully Guard Impact \n" +
                            "patch=1,EE,204D23DC,extended,3E000000 //Recover Health when successfully Guard Impact \n" +
                            "patch=1,EE,204D23E0,extended,3D800000 //Increase Guard Break Chance \n" +
                            "patch=1,EE,204D23E4,extended,40000000 //Increase Throw Escape Rate \n" +
                            "patch=1,EE,204D23E8,extended,40000000 //Increase Ring-Out Escape Rate \n" +
                            "patch=1,EE,204D23F0,extended,C0C00000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04D1FE2,extended,0800001A //if P2 is using Yun-Seong style        \n" +
                            "patch=1,EE,D04D2016,extended,07C00007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3FA00000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204D23BC,extended,3E900000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,204D23C0,extended,3F780000 //Weapon Size \n" +
                            "patch=1,EE,204D23D0,extended,3D800000 //Decrease/Increase Health while guarding enemies attacks \n" +
                            "patch=1,EE,204D23E0,extended,3F000000 //Increase Guard Break Chance \n" +
                            "patch=1,EE,204D23EC,extended,3C800000 //Drain/Recover Health over Time \n" +
                            "patch=1,EE,204D23F0,extended,C0800000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04D1FE2,extended,07000022 //if P2 is using Setsuka style        \n" +
                            "patch=1,EE,D04D2016,extended,06000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3FC00000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204D23AC,extended,00200000 //Guard Impact becomes easier to perform \n" +
                            "patch=1,EE,204D23D4,extended,00000000 //Automatically Guard Impact some attacks \n" +
                            "patch=1,EE,204D23D8,extended,40000000 //Increase Damage Received by Opponent when successfully Guard Impact \n" +
                            "patch=1,EE,204D23DC,extended,40000000 //Recover Health when successfully Guard Impact \n" +
                            "patch=1,EE,204D23EC,extended,3C800000 //Drain/Recover Health over Time \n" +
                            "patch=1,EE,D04D1FE2,extended,05000023 //if P2 is using Tira style        \n" +
                            "patch=1,EE,D04D2016,extended,04000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B8,extended,40000000 //Steal health from enemy \n" +
                            "patch=1,EE,204D23C0,extended,3F900000 //Weapon Size \n" +
                            "patch=1,EE,204D23BC,extended,3E800000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,204D23F0,extended,40600000 //Drain/Recover Health when Attacking \n" +
                            "patch=1,EE,D04D1FE2,extended,06000024 //if P2 is using Zasalamel style        \n" +
                            "patch=1,EE,D04D2016,extended,05000007 //if P2 is using ultimate weapon        \n" +
                            "patch=1,EE,204D23B0,extended,3FB40000 //Decrease/Increase Attack \n" +
                            "patch=1,EE,204D23B8,extended,3F200000 //Steal health from enemy \n" +
                            "patch=1,EE,204D23BC,extended,3E900000 //Damage inflicted thru guard \n" +
                            "patch=1,EE,204D23C0,extended,3F900000 //Weapon Size \n" +
                            "patch=1,EE,204D23EC,extended,BD800000 //Drain/Recover Health over Time \n" +
                            "\n";
                    }





                }
                else
                {
                    //Remove Graphics

                    string copyTo = SettingsClass.GfxCopyTo;
                    // Check if the directory exists before attempting to delete it
                    if (Directory.Exists(copyTo))
                    {
                        // Delete the folder and all its contents
                        Directory.Delete(copyTo, true);
                    }

                    // Recreate the folder
                    Directory.CreateDirectory(copyTo);
                }
            }

                return weaponsCode;
        }


    }
}
