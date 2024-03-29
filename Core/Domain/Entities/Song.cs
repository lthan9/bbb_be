﻿using Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Song : RealEntity
    {
        public int TotalListen { get; set; }
        public int TotalLike { get; set; }
        public int TotalCmt { get; set; }
        public int TotalDownload { get; set; }
        public string Lyric { get; set; }
        public int Duration { get; set; }
        public bool IsPublic { get; set; }
        public bool IsOfficial { get; set; }
        public bool IsChecked { get; set; }
        public bool SongVip { get; set; }
        public string Country { get; set; }
        public string Thumbnail { get; set; }
        public string FileMusic128 { get; set; }
        public string FileMusic320 { get; set; }
        public string FileMusicLossless { get; set; }
        public List<Song_PlayList> Song_PlayLists { get; set; }
        public List<Song_Type> Song_Types { get; set; }
        public List<User_Like_Song> ListUserLike { get; set; }
        public List<User_Cmt_Song> ListUserCmt { get; set; }
        public List<Song_Owner> Song_Owners { get; set; }
        public List<Song_Singer> Song_Singers { get; set; }
        public List<Song_Composer> Song_Composers { get; set; }
        //public List<FileImage> FileImages { get; set; }
        public List<Song_Tag> Song_Tags { get; set; }
        //public FileMusic FileMusic { get; set; }

       
    }
}
