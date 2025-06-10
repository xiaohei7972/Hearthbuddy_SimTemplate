using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：5 攻击力：3 生命值：3
	//Mind Control Tech
	//精神控制技师
	//[x]<b>Battlecry:</b> If your opponenthas 4 or more minions,take control of one.
	//<b>战吼：</b>如果你的对手有4个或者更多随从，夺取其中一个的控制权。
	class Sim_CORE_EX1_085 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                if (p.enemyMinions.Count >= 4)
                {
                    List<Minion> temp = new List<Minion>(p.enemyMinions);
                    temp.Sort((a, b) => a.Angr.CompareTo(b.Angr));
                    Minion targett;
                    targett = temp[0];
                    if (targett.taunt && temp.Count >= 2 && !temp[1].taunt) targett = temp[1];
                    p.minionGetControlled(targett, true, false);

                }
            }
            else
            {
                if (p.ownMinions.Count >= 4)
                {
                    List<Minion> temp = new List<Minion>(p.ownMinions);
                    temp.Sort((a, b) => a.Angr.CompareTo(b.Angr));
                    Minion targett;
                    targett = temp[0];
                    if (targett.taunt && temp.Count >= 2 && !temp[1].taunt) targett = temp[1];
                    p.minionGetControlled(targett, false, false);

                }
            }
		}

        public override PlayReq[] GetPlayReqs()
		{
			return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
				new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
			};
		}


	}

}
		