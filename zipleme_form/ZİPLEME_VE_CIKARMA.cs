using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace zipleme_form
{
    
    public static class ZİPLEME_VE_CIKARMA
    {


        
        /// <summary>
        ///  Dönüştürülen veriyi zipleme işlemi yapar.
        /// </summary>
        /// <returns>Zipli Dosya</returns>
        public static byte[] CompressFile(Dictionary<string, byte[]> documents)
        {
            MemoryStream zipStream = new MemoryStream();

            using (ZipArchive zip = new ZipArchive(zipStream, ZipArchiveMode.Create, true))
            {
                int i = 0;
                Form yakalananForm = Application.OpenForms["Form1"];
                CheckedListBox chckbox = (CheckedListBox)(yakalananForm.Controls["checkedListBox1"]);
                foreach (var document in documents)
                {
                    ZipArchiveEntry zipElaman = zip.CreateEntry(document.Key);
                    Stream entryStream = zipElaman.Open();
                    entryStream.Write(document.Value, 0, document.Value.Length);
                    entryStream.Flush();
                    entryStream.Close();
                    chckbox.SetItemCheckState(i, CheckState.Checked);
                    if (documents.Count > i + 1)
                        chckbox.SetSelected(i + 1, true);
                    chckbox.Refresh();
                    i++;
                }
            }
            zipStream.Position = 0;
            return zipStream.ToArray();
        }


        /// <summary>
        /// Zipli datayı zipten çıkarır
        /// </summary>
        /// <returns>Zipten çıkarılan data</returns>
        public static Dictionary<string, byte[]> UncompressFile(byte[] docData)
        {
          
            Dictionary<string, byte[]> zipsizData = new Dictionary<string, byte[]>();
            MemoryStream zippedStream = new MemoryStream(docData);
            using (ZipArchive archive = new ZipArchive(zippedStream))
            {
                

                foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        MemoryStream ms = new MemoryStream();
                        Stream zipStream = entry.Open();
                        zipStream.CopyTo(ms);
                        zipsizData.Add(entry.FullName, ms.ToArray());
                    }
                

            }
            return zipsizData;
        }
    }
}
