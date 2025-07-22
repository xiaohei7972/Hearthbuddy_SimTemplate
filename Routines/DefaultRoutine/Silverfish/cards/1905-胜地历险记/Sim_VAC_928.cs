using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：3
	//Paraglide
	//飞翼滑翔
	//[x]Both playersdraw 3 cards.<b>Outcast:</b> Only you do.
	//双方玩家抽三张牌。<b>流放：</b>只有你抽牌。
	class Sim_VAC_928 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            
        }
    }
}
