using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_704 : SimTemplate //* 笼斗管理员 Cagematch Custodian
	{
		//战吼：抽一张武器牌。
		//Battlecry: Draw a weapon.

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.ULD_413, own.own, false);//抽分裂战斧 从牌库
        }
	}
}
