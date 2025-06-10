using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_065 : SimTemplate //* 熊猫人进口商 Pandaren Importer
	{
        //[x]<b>Battlecry:</b> <b>Discover</b> aspell that didn't startin your deck.
        //<b>战吼：</b><b>发现</b>一张你的套牌之外的法术牌。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, true);
        }

    }
}
