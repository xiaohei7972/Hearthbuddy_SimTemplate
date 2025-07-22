using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：7
	//Giant Tumbleweed!!!
	//巨型风滚草！
	//Deal $6 damage to all minions. Summon a 6/6 Tumbleweed.
	//对所有随从造成$6点伤害。召唤一个6/6的风滚草。
	class Sim_WW_090 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_090t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			int dmg = 6;
			p.allMinionsGetDamage(dmg);
			p.callKid(kid, pos, ownplay);
		}	



		public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
		
	}
}
