using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：2
	//Siren Song
	//海妖之歌
	//Get two random spells from spell schools you haven't cast this game.
	//随机获取两张你在本局对战中未施放过的派系的法术牌。
	class Sim_VAC_308 : SimTemplate
	{

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.VAC_COIN1, ownplay, true);
            p.drawACard(CardDB.cardIDEnum.VAC_COIN1, ownplay, true);
        }

    }
}
