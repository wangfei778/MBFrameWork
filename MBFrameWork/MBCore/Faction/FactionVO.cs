using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//最简单的 PO 就是对应数据库中某个表中的一条记录
//VO 值对象  Value Object
namespace MBCore
{
    //PO:persistant object 持久对象,可以看成是与数据库中的表相映射
    class FactionVO
    {
        public int _factionID;
        public int _factionName;
        public List<int> _mapTeamTroopIDList;//已经处于地图上的军团列表 一个军团可以包含一个或者多个Troop
        public int _capital;//总基地（首都） 
        public List<int> _ownCityIDList;//已经拥有的city
        public List<int> _ownCastleIDList;//已经拥有的城堡
        public List<int> _ownPassIDList;//关隘
        public List<int> _ownHarbourIDList;//港口
        public FactionType _factionType;//
        public int _factionLeader;
        public List<int> _factionHeroList;//只有hero可以带队， 如果队伍没有hero，直接产生一个随机Hero
        public Dictionary<int, int> _relationDic = new Dictionary<int, int>();//<factionID ,relation>
        public int _colorR;
        public int _colorG;
        public int _colorB;
        public string _flagImgPath;//旗帜文件路径
    }
}
