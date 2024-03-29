﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Domain.Base
{
    public class RealEntity : AuditableBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public bool CompareNoSign(string str)
        {
            var name = Name.ToLower();
            str = str.ToLower();
            Regex[] listRe = {
                new Regex("[à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ]"),
                new Regex("[è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|]"),
                new Regex("[ì|í|ị|ỉ|ĩ]"),
                new Regex("[ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ]"),
                new Regex("[ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ]"),
                new Regex("[ỳ|ý|ỵ|ỷ|ỹ]"),
                new Regex("[đ]"),
            };
            string[] map = { "a", "e", "i", "o", "u", "y", "d", };
            for (int i = 0; i < listRe.Length; i++)
            {
                str = listRe[i].Replace(str, map[i]);
                name = listRe[i].Replace(str, map[i]);
            }
            if (name.Contains(str) || str.Contains(name))
                return true;
            else
                return false;
        }
    }
}
