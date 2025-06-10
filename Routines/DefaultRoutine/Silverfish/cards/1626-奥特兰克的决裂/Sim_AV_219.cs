using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_219 : SimTemplate //* 群羊指挥官 ramcommander
	{
		//<b>战吼：</b>将两张1/1并具有<b>突袭</b>的山羊置入你的手牌。
        //CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_219t);

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.AV_219t, true, true);
            p.drawACard(CardDB.cardIDEnum.AV_219t, true, true);
        }
	}
}
