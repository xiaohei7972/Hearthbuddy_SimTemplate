using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：6
	//Airlock Breach
	//气闸破损
	//[x]Summon a 5/5 Undeadwith <b>Taunt</b> and give yourhero +5 Health. Spend5 <b>Corpses</b> to do it again.
	//召唤一个5/5并具有<b>嘲讽</b>的亡灵，并使你的英雄获得+5生命值。消耗5份<b>残骸</b>，重复一次。
	class Sim_GDB_113 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_113t); 
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            
            p.callKid(kid, place, ownplay, false);
            p.callKid(kid, place, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 2),
            };
        }
		
	}
}
