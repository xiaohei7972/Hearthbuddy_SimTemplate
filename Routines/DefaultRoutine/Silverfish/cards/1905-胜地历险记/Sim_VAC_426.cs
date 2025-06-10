using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：4 攻击力：4 生命值：3
	//Eliza Goreblade
	//伊丽扎·刺刃
	//<b>Deathrattle:</b> For the rest ofthe game, your minionshave +1 Attack.
	//<b>亡语：</b>在本局对战的剩余时间内，你的随从拥有+1攻击力。
	class Sim_VAC_426 : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                //增加伊丽扎·刺刃光环数量
                p.ownElizagoreblade++;

                // 给场上所有己方随从增加1点攻击力
                foreach (Minion minion in p.ownMinions)
                {
                    p.minionGetBuffed(minion, 1, 0);
                }

                // 给手牌中的所有随从牌增加1点攻击力
                foreach (Handmanager.Handcard hc in p.owncards)
                {
                    hc.addattack += 1;
                }
            }
        }
    }
}
