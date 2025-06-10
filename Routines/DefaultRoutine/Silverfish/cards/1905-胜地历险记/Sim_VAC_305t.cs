using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：3 攻击力：2 生命值：4
	//Ice Sculpture
	//冰雕
	//<b>Taunt</b><b>Deathrattle:</b> Gain 4 Armor.
	//<b>嘲讽</b>。<b>亡语：</b>获得4点护甲值。
	class Sim_VAC_305t : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.minionGetArmor(p.ownHero, 4);
        }
    }
}
