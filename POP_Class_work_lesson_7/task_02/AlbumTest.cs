using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_8
{
    public class AlbumTest
    {
        public void Test()
        {
            PhotoAlbum albumDefault = new PhotoAlbum();

            PhotoAlbum album24pages = new PhotoAlbum(24);

            BigPhotoAlbum bigPhotoAlbum = new BigPhotoAlbum();

            Console.WriteLine($"albumDefault pages={albumDefault.GetNumberOfPages()}");

            Console.WriteLine($"album24pages pages={album24pages.GetNumberOfPages()}");

            Console.WriteLine($"bigPhotoAlbum page={bigPhotoAlbum.GetNumberOfPages()}");
        }
    }
}
