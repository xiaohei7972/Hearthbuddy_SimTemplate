using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：3
	//Turn the Tides
	//潮流逆转
	//[x]Give your hero +3 Attackthis turn. Summon a 3/3Elemental with <b>Rush</b>.<b>Overload:</b> (1)
	//在本回合中，使你的英雄获得+3攻击力。召唤一个3/3并具有<b>突袭</b>的元素。<b>过载：</b>（1）
	class Sim_TTN_722 : SimTemplate
	{

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TTN_833t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetTempBuff(ownplay ? p.ownHero : p.enemyHero, 3, 0);

			int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, ownplay);
			p.ueberladung += 1;
        }
		
	}
}
