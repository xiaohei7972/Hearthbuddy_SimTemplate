using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_571 : SimTemplate //* 神秘之刃 Mysterious Blade
//<b>Battlecry:</b> If you control a<b>Secret</b>, gain +1 Attack.
//<b>战吼：</b>如果你控制一个<b>奥秘</b>，便获得+1攻击力。 
	{



        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DAL_571);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(weapon, ownplay);

            if (target != null)  p.ownWeapon.Angr += 1;
		}
	}
}
        