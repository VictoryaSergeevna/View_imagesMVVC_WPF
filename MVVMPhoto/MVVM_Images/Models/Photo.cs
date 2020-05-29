using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_Images.Helpers;

namespace MVVM_Images.Models
{
    public class Photo : ObservableObject
    {
        private string imageSource;
        private string fileName;
        private int fileSize;
        private string fullPath;

        public string FullPath
        {
            get { return fullPath; }
            set
            {
                if (fullPath != value)
                {
                    fullPath = value;
                }
            }
        }


        public string ImageSource
        {
            get { return imageSource; }
            set
            {
                if (imageSource != value)
                {
                    imageSource = value;
                    OnPropertyChanged("ImageSource");
                }
            }
        }
        public string FileName
        {
            get { return fileName; }
            set
            {
                if (fileName != value)
                {
                    fileName = value;
                    OnPropertyChanged("FileName");
                }
            }
        }
        public int FileSize
        {
            get { return fileSize; }
            set
            {
                if (fileSize != value)
                {
                    fileSize = value;
                    OnPropertyChanged("FileSize");
                }
            }
        }

        public Photo Clone()
        {
            Photo newPhoto = new Photo();
            newPhoto.ImageSource = this.ImageSource;
            newPhoto.FileName = this.FileName;
            newPhoto.FileSize = this.FileSize;
            newPhoto.FullPath = this.FullPath;
            return newPhoto;
        }

    }
}
