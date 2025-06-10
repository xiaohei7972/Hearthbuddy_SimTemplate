using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 战士 费用：5 攻击力：5 生命值：5
	//Fireworker
	//焰火机师
	//<b>Deathrattle:</b> Summon two 1/1 Boom Bots. <i>WARNING: Bots may explode.</i>
	//<b>亡语：</b>召唤两个1/1的砰砰机器人。<i>警告：该机器人随时可能爆炸。</i>
	class Sim_TOY_908 : SimTemplate
	{

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 召唤两个1/1的砰砰机器人
            for (int i = 0; i < 2; i++)
            {
                p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_110t), m.zonepos, m.own);
            }
        }

    }
}
