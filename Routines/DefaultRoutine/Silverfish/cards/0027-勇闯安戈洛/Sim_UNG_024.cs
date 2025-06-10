using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_024 : SimTemplate //* 法术共鸣 Mana Bind
//<b>Secret:</b> When your opponent casts a spell, add a copy to your hand that costs (0).
//<b>奥秘：</b>当你的对手施放一个法术时，将该法术的一张复制置入你的手牌，其法力值消耗变为（0）点。 
	{
		

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
        }
    }
}