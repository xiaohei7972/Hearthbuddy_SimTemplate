using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：5
	//Command of Neptulon
	//耐普图隆的指令
	//Summon two 5/4 Elementals with <b>Rush</b>.<b>Overload:</b> (1)
	//召唤两个5/4并具有<b>突袭</b>的元素。<b>过载：</b>（1）
	class Sim_TID_005 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TID_005t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
			p.lockedMana++;
		}

        public override PlayReq[] GetPlayReqs()
        {
			return new PlayReq[]{
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS,1), // 需要一个空位
			};
        }
		
	}
}
