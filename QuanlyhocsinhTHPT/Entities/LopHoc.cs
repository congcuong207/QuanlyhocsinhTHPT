using System;
using System.Collections.Generic;
using System.Text;

namespace QuanlyhocsinhTHPT.Entities
{
    class LopHoc
    {
        private string maLop;
        private string tenLop;
        private string maGVCN;
        private int siSO;

        public LopHoc()
        {
            siSO= 0;
        }

        public LopHoc(string maLop, string tenLop, string maGVCN, int siSO)
        {
            this.MaLop = maLop;
            this.TenLop = tenLop;
            this.MaGVCN = maGVCN;
            this.SiSO = siSO;
        }

        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string MaGVCN { get => maGVCN; set => maGVCN = value; }
        public int SiSO { get => siSO; set => siSO = value; }
    }
}
