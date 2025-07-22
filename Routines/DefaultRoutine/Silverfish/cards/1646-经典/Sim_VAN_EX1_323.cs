using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_323 : SimTemplate //* 加拉克苏斯大王 Lord Jaraxxus
	{
		//<b>Battlecry:</b> Destroy your hero and replace it with Lord Jaraxxus.
		//<b>战吼：</b>消灭你的英雄，并用加拉克苏斯大王替换之。

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_323w);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(weapon, own.own);
            p.setNewHeroPower(CardDB.cardIDEnum.EX1_tk33, own.own); // INFERNO!

            if (own.own)
            {
                p.ownHeroName = HeroEnum.lordjaraxxus;
                p.ownHero.Hp = own.Hp;
                p.ownHero.maxHp = own.maxHp;
            }
            else 
            {
                p.enemyHeroName = HeroEnum.lordjaraxxus;
                p.enemyHero.Hp = own.Hp;
                p.enemyHero.maxHp = own.maxHp;
            }
		}
	}
}