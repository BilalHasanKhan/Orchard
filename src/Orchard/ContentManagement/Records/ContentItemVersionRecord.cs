using System;
using Orchard.ContentManagement.FieldStorage;
using Orchard.ContentManagement.FieldStorage.InfosetStorage;

namespace Orchard.ContentManagement.Records {
    public class ContentItemVersionRecord {
        public ContentItemVersionRecord() {
            Infoset = new Infoset();
        }

        public virtual int Id { get; set; }
        public virtual ContentItemRecord ContentItemRecord { get; set; }
        public virtual int Number { get; set; }

        public virtual bool Published { get; set; }
        public virtual bool Latest { get; set; }

        public virtual string Data { get { return Infoset.Data; } set { Infoset.Data = value; } }
        public virtual Infoset Infoset { get; private set; }
    }
}
