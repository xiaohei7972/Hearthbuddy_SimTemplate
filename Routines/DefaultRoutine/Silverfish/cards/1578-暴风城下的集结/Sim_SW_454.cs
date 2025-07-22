using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_454 : SimTemplate //* 雄狮之怒 Lion's Frenzy
	{
        //Has Attack equal to the number of cards you've drawn this turn.
        //攻击力等同于你在本回合中抽牌的数量。
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_454);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
            if (ownplay)
            {
                p.ownWeapon.Angr = p.owncarddraw;
            }
        }
    }
}
