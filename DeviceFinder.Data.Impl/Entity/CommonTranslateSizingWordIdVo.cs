//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeviceFinder.Data.Impl.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommonTranslateSizingWordIdVo
    {
        public CommonTranslateSizingWordIdVo()
        {
            this.Common_ProductFamily = new HashSet<CommonProductFamilyVo>();
            this.Common_ProductLine = new HashSet<CommonProductLineVo>();
            this.Common_ProductProperty = new HashSet<CommonProductPropertyVo>();
            this.Common_ProductPropertyGroup = new HashSet<CommonProductPropertyGroupVo>();
            this.Common_TranslateSizingWord = new HashSet<CommonTranslateSizingWordVo>();
        }
    
        public int WordId { get; set; }
    
        public virtual ICollection<CommonProductFamilyVo> Common_ProductFamily { get; set; }
        public virtual ICollection<CommonProductLineVo> Common_ProductLine { get; set; }
        public virtual ICollection<CommonProductPropertyVo> Common_ProductProperty { get; set; }
        public virtual ICollection<CommonProductPropertyGroupVo> Common_ProductPropertyGroup { get; set; }
        public virtual ICollection<CommonTranslateSizingWordVo> Common_TranslateSizingWord { get; set; }
    }
}