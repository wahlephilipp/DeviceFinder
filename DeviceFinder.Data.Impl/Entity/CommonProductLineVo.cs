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
    
    public partial class CommonProductLineVo
    {
        public CommonProductLineVo()
        {
            this.Common_ProductFamily = new HashSet<CommonProductFamilyVo>();
            this.Common_ProductProperty = new HashSet<CommonProductPropertyVo>();
        }
    
        public int ProductLineId { get; set; }
        public int ProductLineName { get; set; }
        public int DisplaySequence { get; set; }
    
        public virtual CommonTranslateSizingWordIdVo Common_TranslateSizingWordId { get; set; }
        public virtual ICollection<CommonProductFamilyVo> Common_ProductFamily { get; set; }
        public virtual ICollection<CommonProductPropertyVo> Common_ProductProperty { get; set; }
    }
}