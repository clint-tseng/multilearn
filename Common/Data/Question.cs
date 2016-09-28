using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace MultiLearn.Data
{
    [Serializable]
    public class Question
    {
        [XmlAttribute("ID")]
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        private int _id;

        public Guid PictureGuid
        {
            get { return this._pictureGuid; }
            set 
            { 
                _pictureGuid = value;

                // Image.FromFile(..) locks the file until the Image is disposed, so we have to do this instead.
                using (FileStream stream = new FileStream(
                    string.Format("{0}\\{1}.png", Constants.Directories.Temp, _pictureGuid.ToString()), 
                    FileMode.Open)) 
                {
                    this._image = Image.FromStream(stream);
                }
            }
        }
        protected Guid _pictureGuid;

        [XmlIgnoreAttribute]
        public Image Image 
        {
            get { return this._image; }
            set { this._image = value; }
        }
        private Image _image;

        protected Question(Image image) 
        {
            this._image = image;
            this._pictureGuid = Guid.NewGuid();
        }

        protected Question()
        { 
            // for serialization purposes
        }
    }
}