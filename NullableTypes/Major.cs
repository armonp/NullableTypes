using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    class Major {
        //id, description, minSAT
        public int Id { get; set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }

        
        private static int mId = 0;
        public Major() {
            this.Id = mId += 1;
            mId++;
        }

    }
}
