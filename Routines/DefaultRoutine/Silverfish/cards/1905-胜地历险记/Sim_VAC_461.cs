using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：2 攻击力：2 生命值：2
	//Drink Server
	//饮品侍者
	//<b>Deathrattle:</b> Get arandom Drink spell.<i>(It has 3 uses!)</i>
	//<b>亡语：</b>随机获取一张饮品法术牌。<i>（饮品可以饮用3次！）</i>
	class Sim_VAC_461 : SimTemplate
	{

        public override void onDeathrattle(Playfield p, Minion m)
        {
            // 亡语效果：抽一张牌
            p.drawACard(CardDB.cardIDEnum.None, m.own, true);
        }
    }
}
