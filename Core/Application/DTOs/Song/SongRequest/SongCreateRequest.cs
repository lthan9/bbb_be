﻿using Microsoft.AspNetCore.Http;
using Application.DTOs.SongType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Application.DTOs.Song.SongRequest
{
    public class SongCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Lyric { get; set; }
        public int Duration { get; set; }
        public IFormFile Thumbnail { get; set; }
        public IFormFile FileMusic { get; set; }
        public List<int> SongTypes { get; set; }
        public List<int> Tags { get; set; }

    }
}
