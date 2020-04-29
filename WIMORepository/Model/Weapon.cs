//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WIMORepository.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Weapon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Weapon()
        {
            this.WeaponForAgentSpec = new HashSet<WeaponForAgentSpec>();
            this.WeaponHistory = new HashSet<WeaponHistory>();
            this.WeaponStoreLog = new HashSet<WeaponStoreLog>();
        }
    
        public int IDWeapon { get; set; }
        public string WeaponName { get; set; }
        public int IDWeaponType { get; set; }
        public int IDCaliber { get; set; }
        public decimal Weight { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Caliber Caliber { get; set; }
        public virtual WeaponType WeaponType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeaponForAgentSpec> WeaponForAgentSpec { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeaponHistory> WeaponHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeaponStoreLog> WeaponStoreLog { get; set; }
    }
}