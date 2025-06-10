using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：8 攻击力：8 生命值：8
	//Mo'arg Forgefiend
	//莫尔葛熔魔
	//<b>Taunt</b><b>Deathrattle:</b> Gain 8 Armor.
	//<b>嘲讽</b>，<b>亡语：</b>获得8点护甲值。
	class Sim_SW_068_COPY : SimTemplate
	{

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 获得8点护甲值
            if (m.own)
            {
                p.ownHero.armor += 8; // 己方英雄获得8点护甲
            }
            else
            {
                p.enemyHero.armor += 8; // 敌方英雄获得8点护甲
            }
        }
    }
}
