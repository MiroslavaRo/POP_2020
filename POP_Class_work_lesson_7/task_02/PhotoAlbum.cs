using System;
using System.Collections.Generic;
using System.Text;

namespace POP_Class_work_lesson_8
{
    public class PhotoAlbum
    {
        private int numberOfPages;

        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

        public PhotoAlbum() : this(16)
        {
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
