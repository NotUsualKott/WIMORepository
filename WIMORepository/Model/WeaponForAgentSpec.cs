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
    
    public partial class WeaponForAgentSpec
    {
        public int IDWeaponForAgentSpec { get; set; }
        public int IDWeapon { get; set; }
        public int IDAgentSpecialization { get; set; }
    
        public virtual AgentSpecialization AgentSpecialization { get; set; }
        public virtual Weapon Weapon { get; set; }
    }
}
