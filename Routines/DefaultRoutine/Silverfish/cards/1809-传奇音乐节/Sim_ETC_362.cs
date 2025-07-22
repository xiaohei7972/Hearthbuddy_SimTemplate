using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：5
	//JIVE, INSECT!
	//跳吧，虫子！
	//Transform a minion intoRagnaros the Firelord.<b>Overload:</b> (2)
	//将一个随从变形成为炎魔之王拉格纳罗斯。<b>过载：</b>（2）
	class Sim_ETC_362 : SimTemplate
	{
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_298);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionTransform(target, card);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
				new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),  // 目标必须是我方
            };
        }
	}
}
