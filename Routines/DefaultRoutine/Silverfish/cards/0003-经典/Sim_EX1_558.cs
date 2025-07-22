using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_558 : SimTemplate //* 哈里森·琼斯 Harrison Jones
	{
		//<b>Battlecry:</b> Destroy your opponent's weapon and draw cards equal to its Durability.
		//<b>战吼：</b>摧毁对手的武器，并抽数量等同于其耐久度的牌。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                //this.owncarddraw += enemyWeaponDurability;
                for (int i = 0; i < p.enemyWeapon.Durability; i++)
                {
                    p.drawACard(CardDB.cardIDEnum.None, true);
                }
                p.lowerWeaponDurability(1000, false);
            }
            else
            {
                for (int i = 0; i < p.enemyWeapon.Durability; i++)
                {
                    p.drawACard(CardDB.cardIDEnum.None, false);
                }
                p.lowerWeaponDurability(1000, true);
            }
		}


	}
}