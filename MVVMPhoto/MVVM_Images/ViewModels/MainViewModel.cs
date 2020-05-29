using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MVVM_Images.Helpers;
using MVVM_Images.Models;
using Microsoft.Win32;
using System.IO;

namespace MVVM_Images.ViewModels
{
    public class MainViewModel : ObservableObject
    {
     public ObservableCollection<Photo> Photos { get; set; }
        private Photo selectedPhoto;
        public Photo SelectedPhoto
        {
            get { return selectedPhoto; }
            set
            {
                if (selectedPhoto != value)
                {
                    selectedPhoto = value;
                    OnPropertyChanged(nameof(selectedPhoto));
                }
            }
        }

        public MainViewModel()
        {
            Photos = new ObservableCollection<Photo>();
        }

        RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            set { addCommand = value; }
            get
            {
                //если null возвращается первая часть, если нет вторая
                return addCommand ?? (addCommand = new RelayCommand(
                    (obj) =>
                    {
                        OpenFileDialog fileDialog = new OpenFileDialog();
                        if (fileDialog.ShowDialog() == true)
                        {
                            Photo photo = new Photo { ImageSource = fileDialog.FileName };
                            FileInfo fi = new FileInfo(fileDialog.FileName);
                            photo.FullPath = fileDialog.FileName;
                            photo.FileName = fi.Name;
                            photo.FileSize = (int)fi.Length / 1024;
                            Photos.Add(photo);
                            SelectedPhoto = photo;
                        }                         
                        
                    }
                    ));
            }
        }
        RelayCommand deleteCommand;

        //первый способ
        public RelayCommand DeleteCommand
        {
            set { deleteCommand = value; }
            get
            {
                return deleteCommand ?? (deleteCommand = new RelayCommand(
                  (obj) =>
                  {
                      Photo photo = obj as Photo;
                      if (photo != null)
                      {
                          Photos.Remove(photo);
                      }
                  },
                  //(obj)=>{return Cars.Count>0;}
                  obj => (Photos.Count > 0)
                    ));
            }
        }
    }
}
