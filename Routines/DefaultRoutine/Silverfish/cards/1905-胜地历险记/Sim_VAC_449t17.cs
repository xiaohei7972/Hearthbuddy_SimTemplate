using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：5 生命值：5
	//Carress, Cabaret Star
	//歌唱明星卡瑞斯
	//<b>Battlecry:</b> Gain +2/+2and <b>Taunt</b>.Deal 2 damage to all enemy minions.
	//<b>战吼：</b>获得+2/+2和<b>嘲讽</b>。对所有敌方随从造成2点伤害。
	class Sim_VAC_449t17 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 增加+2/+2
            p.minionGetBuffed(own, 2, 2);

            // 赋予嘲讽
            own.taunt = true;

            // 对所有敌方随从造成2点伤害
            p.allMinionOfASideGetDamage(!own.own, 2);
        }
    }
}
