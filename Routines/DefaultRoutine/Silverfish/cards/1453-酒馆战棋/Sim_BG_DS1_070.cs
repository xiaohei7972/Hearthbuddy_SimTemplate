using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：0 攻击力：4 生命值：3
	//Houndmaster
	//驯兽师
	//<b>Battlecry:</b> Give a friendly Beast +2/+2 and <b>Taunt</b>.
	//<b>战吼：</b>使一个友方野兽获得+2/+2和<b>嘲讽</b>。
	class Sim_BG_DS1_070 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetBuffed(target, 2, 2);
                if (target != null)
                {
                    if (!target.taunt)
                    {
                        target.taunt = true;
                        if (target.own) p.anzOwnTaunt++;
                        else p.anzEnemyTaunt++;
                    }
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_RACE, 20),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
		
	}
}
