using System;

namespace HREngine.Bots
{
	class Sim_ULD_433p : SimTemplate //* 升格卷轴 Ascendant Scroll
	{
		//<b>Hero Power</b>Add a random Magespell to your hand.It costs (2) less.
		//<b>英雄技能</b>随机将一张法师法术牌置入你的手牌。该牌的法力值消耗减少（2）点。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.drawACard(CardDB.cardNameEN.unknown, ownplay, true);
			p.owncards[p.owncards.Count - 1].manacost = Math.Max(p.owncards[p.owncards.Count - 1].manacost -= 2, 0);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_HAND_NOT_FULL),
            };
        }
	}
}