using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_037 : SimTemplate //* 毒袭之弓 Venomstrike Bow
	{
        //<b>Poisonous</b>
        //<b>剧毒</b>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_037), true);
        }

    }
}
