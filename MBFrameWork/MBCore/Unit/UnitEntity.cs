using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBCore.Unit
{
    //不可升级，升级就是另外类型的soldier
    class SoldierEntity
    {
        public string _unitModelPath;
        public int _maxHp;
        public int _curHP;
        public int _baseMeeleAttackPoint;//还需要加上装备，士气，技能，科技
        public int _baseMeeleDefPoint;// 都是绝对值
        public int _baseRemoteAttackPoint;
        public int _baseRemoteDefPoint;//  
        public int _baseMovePoint;
        public int _baseDefFire;//防火 百分比 0到100
        public int _baseDefPoison;//防毒 百分比
        public List<int> _weaponIDList;//
        public List<int> _defClothIDList;//
        public int _curExp;
        public int _levelUpExp;
        public List<int> _levelUpSoldierIDList;
    }
}
