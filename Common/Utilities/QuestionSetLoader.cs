using System.IO;
using System.Xml.Serialization;
using Ionic.Zip;
using MultiLearn.Data;

namespace MultiLearn.Utilities
{
    public static class QuestionSetLoader
    {
        public static void SaveQuestionSet(QuestionSet set)
        {
            using (ZipFile zip = new ZipFile())
            {
                // add the metadata xml
                MemoryStream xmlStream = new MemoryStream();
                XmlSerializer serializer = new XmlSerializer(typeof(QuestionSet));
                serializer.Serialize(xmlStream, set);
                zip.AddFileStream(Constants.Files.MetaDataXML, string.Empty, xmlStream);

                // add the images
                MemoryStream[] streams = new MemoryStream[set.Questions.Count];
                for (int i = 0; i < set.Questions.Count; i++)
                {
                    streams[i] = new MemoryStream();
                    if (set.Questions[i].Image != null && set.Questions[i].PictureGuid != null)
                    {
                        set.Questions[i].Image.Save(streams[i], System.Drawing.Imaging.ImageFormat.Png);
                        zip.AddFileStream(string.Format("{0}.png", set.Questions[i].PictureGuid.ToString()), string.Empty, streams[i]);
                    }
                }

                // save
                zip.Save(string.Format("{0}\\{1}.{2}", Constants.Directories.Sets, set.Name, Misc.ExtensionForQuestionSetType(set.Type)));

                // dispose of streams
                xmlStream.Flush();
                xmlStream.Dispose();
                foreach (MemoryStream stream in streams)
                {
                    stream.Flush();
                    stream.Dispose();
                }
            }
        }

        public static QuestionSet OpenQuestionSet(string name, QuestionSetType type)
        {
            using (ZipFile zip = ZipFile.Read(string.Format("{0}\\{1}.{2}", Constants.Directories.Sets, name, Misc.ExtensionForQuestionSetType(type))))
            {
                zip.ExtractAll(Constants.Directories.Temp, true);
            }

            using (StreamReader reader = new StreamReader(string.Format("{0}\\{1}", Constants.Directories.Temp, Constants.Files.MetaDataXML)))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(QuestionSet));
                
                return (QuestionSet)serializer.Deserialize(reader);
            }
        }
    }
}
