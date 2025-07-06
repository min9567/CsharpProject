using System;
using System.Collections.Generic;

namespace Data  // 프로젝트 네임스페이스 맞게 조정
{
    public static class ItemStore
    {
        public static List<Item> Items = new List<Item>();
    }

    public class Item
    {
        public string 품명 { get; set; }
        public int 수량 { get; set; }
        public string 등록자 { get; set; }
        public DateTime 등록일시 { get; set; }
    }
}
