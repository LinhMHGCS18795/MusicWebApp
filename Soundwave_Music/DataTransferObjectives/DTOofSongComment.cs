using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Soundwave_Music.DataTransferObjectives
{
    public class DTOofSongComment
    {
        public int Song_comment_id { get; set; }
        public string Content { get; set; }
        public DateTime Create_date { get; set; }
        public string Status { get; set; }
        public int Song_id { get; set; }
        public int User_id { get; set; }
        public int Full_name { get; set; }
    }
}