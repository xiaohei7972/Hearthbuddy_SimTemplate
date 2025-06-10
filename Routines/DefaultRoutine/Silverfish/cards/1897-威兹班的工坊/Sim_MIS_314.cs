using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：6 生命值：3
	//Building-Block Golem
	//积木魔像
	//[x]<b>Rush</b><b>Deathrattle:</b> Summon threerandom 1-Cost minions.
	//<b>突袭</b>。<b>亡语：</b>随机召唤三个法力值消耗为（1）的随从。
	class Sim_MIS_314 : SimTemplate
	{
        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 随机召唤三个法力值消耗为1的随从
            for (int i = 0; i < 3; i++)
            {
                CardDB.Card randomMinion = p.getRandomCardForManaMinion(1);
                p.callKid(randomMinion, m.zonepos, m.own);
            }
        }
    }
}
