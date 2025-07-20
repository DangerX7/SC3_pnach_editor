using SC3_pnach_editor.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
                    if (customWpnEffectsP1)
                    {
                        MessageBox.Show("Set Player 1 Weapon Effect to original! Can't have Ultimate Weapons and Weapon Effect activated at the same time!", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                        return "";
                    }
                    if (customWpnEffectsP2)
                    {
                        MessageBox.Show("Set Player 2 Weapon Effect to original! Can't have Ultimate Weapons and Weapon Effect activated at the same time!", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
                        return "";
                    }

                    //Copy Graphics
                    string ultimateWeaponsFolder = @"\Ultimate_Weapons";

                    string copyFrom = SettingsClass.GfxCopyFrom + ultimateWeaponsFolder;
                    string copyTo = SettingsClass.GfxCopyTo + ultimateWeaponsFolder;

                    //Copy Ultimate Weapons
                    // Check if the directory exists before attempting to delete it

                    if (Directory.Exists(copyTo))
                    {
                        Directory.Delete(copyTo, true);
                    }

                    CopyDirectory(copyFrom, copyTo);

                    #region weapon text

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
                    #endregion


                    #region weapon effects                    
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

                    #endregion


                }
                else
                {
                    //Remove Graphics

                    string copyTo = SettingsClass.GfxCopyTo + @"\Ultimate_Weapons";
                    // Check if the directory exists before attempting to delete it
                    if (Directory.Exists(copyTo))
                    {
                        // Delete the folder and all its contents
                        DeleteFolder(copyTo);
                    }

                    //// Recreate the folder
                    //Directory.CreateDirectory(copyTo);
                }
            }

                return weaponsCode;
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

    }

}
