﻿using Application.DTOs.Owner;
using Application.DTOs.Tag;
using Application.DTOs.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.Song
{
    public class SongDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public int TotalListen { get; set; }
        public int TotalLike { get; set; }
        public int TotalCmt { get; set; }
        public int TotalDownload { get; set; }
        public string Lyric { get; set; }
        public bool SongVip { get; set; }
        public string Country { get; set; }
        public bool IsChecked { get; set; }
        public bool IsOfficial { get; set; }
        public string Thumbnail { get; set; }
        public string FileMusic128 { get; set; }
        public string FileMusic320 { get; set; }
        public string FileMusicLossless { get; set; }
        public int Duration { get; set; }
        public List<TypeValueDTO> Types { get; set; }
        public List<TagDTO> Tags { get; set; }
        public List<OwnerDTO> Owners { get; set; }
        public List<SingerDTO> Singers { get; set; }
        public List<ComposerDTO> Composers { get; set; }
    }
}
