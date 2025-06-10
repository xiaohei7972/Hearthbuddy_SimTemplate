using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_100 : SimTemplate //* 阿肯尼特防护水晶 
	{
        //<b>Taunt</b> <b>Deathrattle:</b> Gain 6 Armor. <b>Starship Piece</b>
        //<b>嘲讽</b>。<b>亡语：</b>获得6点护甲值。 <b>星舰组件</b>
        public override void onDeathrattle(Playfield p, Minion m)//亡语
        {
            p.minionGetArmor(m.own ? p.ownHero : p.enemyHero, 6);
        }
    }
}
