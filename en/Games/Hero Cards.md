# Hero Cards (王牌)

> Very violent game.

Tags: Table-top, game, card game, minigame

(ORIGINALLY A FICTIONAL GAME IN DEEP DIVE 2021 DEVELOPMENT, NOW TAKEN DIRECTLY INTO PROJECT NINE)
(ASK CHATGPT TO HELP ELABORATE rules, designs, card types)
(ASK CHATGPT FOR MORE SPECIFIC CHARACTER/MAGIC ELEMENTS AND FULLFILL THE CONTENTS)

Hero Card is one of the many variations (compared to "Poker") from the original common predecessor was Kings' Cards. Kings' Cards (Ancient) is developed into Hero Cards and (Poker-like game) Kings' Cards (Modern). The latter modern variant has the same name as the ancient one, and it has a few suites and numbered cards for all kinds of simplified non-magical card plays. Notice in our world there is no such a thing as "Poker". A key feature of modern (especially played by kids) version is dead units are torn apart.

## Hero Cards Collectable Card Game

Game Goals: 1) Collect cards; 2) Defeat others.

General ideas:

* (Effect) Cards (with permittable and suitable form-factor) may be placed **flipped**, thus not directly visible what it is (some **Inspection** skill can see it). For those casrds the cost should be written on the back.
    * (Form Factor) Maybe **cost for all cards should be written on the back**.
    * (Remark) **Cost** is the only immutable property of a card.
* (Game Mode) Mix-and-Match: Don't use personal library, mix in a bunch of cards, draw and play. Suitable for casual and new players.
* (King's Card) Sacrifice (to Graveyard) vs Consume (Tear Apart). The player is the Summoner/King/Commander. Certain (hero) cards have this level up mechanism, usually 1-5, with a numeral and a multiplier - the numeral denotes killing counts to reach that level, and the multiplier multiplies both the cost and effect of any number associated with any skill, and attack power. Remaining health gets multiplied once during level up. Level up is updated at the end of any killing that involves the unit. Unit Types/Ranks/Positions: Royal King, King's Knight, Hero, Human Soldier, Dark Knight, Artifact, Weapon, Horse, Armor, Food, Energy Token (Virtual Currency, Equivalent as Real Dollars, 1 cent each, also available in 5 and 10 cent pieces). At the beginning of each session, the players must agree on max allowed money to spend in each game - since there is no limit on the use of cards, whoever first spent that much money risk losing since they can no longer spend more in that game: this is called "max bet". It's said King's Cards (marketing) is played by *ancient kings* (thus with mystical elements) for entertainment, and settling important matters. This is an ONLINE game! It requires 2 gadgets: A fancy game board (size limits play area) that at least provides a tactile sensor and a minimal input display (can be wooden or purely electrical, usually foldable, and for fancy and good ones the background is fully animated, even with sound effects). Every player also holds a 鉴别器 - Inspecting Tablet (like Pokemon): a device that is always online and can tell the attributes and available skills of a unit. Every card is unique! A card is quite thick with good material, and am embedded ID chip. It has only a generic (sometimes special) background and a foreground print - all attributes, including current health, armor, attack, rank, and skills, are digitalized and available on the tablet. A tablet is NFC paird with a Battlefield board and automatically shows details of a card on tap. A board doesn't even need a display if at least one such tablet is connected. A typical mobile phone also works. You can also use the app or visit an authorized dealer for identity transfer for different skins of the same character. You can also play completely digitally and online or local (requires network connection) - with exactly the same card identities and publishing restrictions: this is the "Same World" scheme. No crafting crap if it will cause out of sync from the reality. You can also customize your own character! Learn new skills, do compaigns, and rank up!
    * (History, Idea) A medieval peace-pact committe (which is THE MOST POWERFUL kingdom in its own who just wants to 多管闲事) publish those cards and distribute them every year - kingdoms can purchase it with money, but the total amount available in circulation is limited by the committe. If any kingdom exhausts all its play cards and still wants to fight, then the committe will send troops to publish that country. That committe was the **Poverty Empire**.
* (Name, #Change) Hero Cards -> King's Cards
* (Name, Item, #Change) Coin -> Coin Token
* (Observation, Issue) Due to the nature of this game, the King must be intimately familiar with its library for the game to be playable. What about new players? Start with a small set?
* (Playtest) The quickest way to test this game is to **print out physical cards and library book and play locally**. This way we avoid software development related troubles. The easiest and cheapest way is, instead of printing anything: we just write down Card Type/names on paper and hand it out.
* (Rule) You cannot make placements in opponents' turn. (Deprecated) So you can't cast spells directly from Vault in opponents' turn - those must be placed on the table during player's turn. Similarly, since placement counts as a Card Action, you cannot use cast spells during first placement. (Clarification) The previous sentence is wrong: Vault and the fortune (coin or cash) you posses is a ready-to-use asset so you should be able to cast whenever you want.
* (Specification) Board size is specified by Frontline slot size: usually comes in 3, 5, 7, 9 and unlimited (tournament). Such board size is useful in limiting (alogn with max bet) how many units a player can summon for a game. Such restriction is applicable to all units, excluding spells, curses, charms, and equipments.
* Tips and Design Guidances: 1) Ordinary units are usually purchased with golds - special and legendary units are usually summoned with energy tokens. 2) Energy tokens can be purchased directly, but it's usually expensive to do so - consider using buildings to generate those energies gradually instead.
* Analysis: If someone has a level 5 (or even level 15?) soldier, and since the recruit cost usually doesn't change - if the opponent doesn't have anything matching it, then very likely the opponent will and should lose the game eventually. This makes sense since: 1) That level 15 unit is a result of long-training and long playing - skill levels are essentially practice levels; 2) Some surprising attacks and cards can make the summoner regret summoning that level 15 (e.g. if the opponent possess a cleansing card), so it's not necessarily a totally determined outcome - the charm of this card game is that you don't know what the other player hides in his deck, it's completely circumstantial. But everything shares a common framework that is consistent and actually makes sense.

Amendment 20211217:

* Pure, Real, Connected collection; When not played online with official (rule) Operation Set, experience points are not accumulated. Some upgrading rules are explicitly hidden. The game is intended to solve the inconsostency issue of Pokemon cards, Magic cards and alike.
* All cards have GUID associated with each instance, so the core of each card is just it's GUID - for physical card it can be embedded with or without a chip but ultimately the online database (or local database) is responsible for storing the Consistent Set (the final state of all cards). For print, each card can have just an image, because all other data are stored digitally and potentially mutable (even Names!). The only one value associated with each unit that won't change is its (placement) Cost, usually in the form and increment of 50's, e.g. 350 - this is intentionally unitless so players can decide associated value and medium for each game. The total allowable publishing number of each card is controlled and published - Local Games can selectively respect those.
* Form Factors (might want to restrict it for visual consistency, but then again, each one of them should be interchangeable form-factor wise): Physical GUID Slip, Digital, Physical Pure Card with print GUID, Physical Square Core with Bar Code on the Back. Notice you just need to purchase once and all other form factors (same skin) are free and redeemable/replaceable when lost; For registered players the entire card is replaceable when lost for free for once.
* Cards are officially purchased, same price for digital and physical media, potentially with different skins (different skins can either map to new cards or tbe same card), with publishing time and volume controlled around the world. All internal test cards are destroyed (physically and digitally) and do not count towards this. Cards are usually sold on a first-come first-get basis with the same price ($25 each), and publishing amount is only announced after a Batch/Season/Update's official sales period is ended (usually 3 months). All cards have limited supply to keep things unique and interesting except the Pawn (category) card which is sold at $12 and unlimited, with explicit rule: *"150 Cost. 12 Health. 4 Attack. 2 Defence. This card has no additional rules."* Pawns do not gain from battles - they are just pawns. When used well the sheer quantity of pawns can help winning. Different skins may be published for Pawn cards, some are rare, but only for cosmetic and promotion purpose. Each new beginner registration can receive 5 Pawn cards, 1 hero card, and 3 random basic cards (won't be resource dependant) from non-character categories. Sales are usually done in: 1) Specific cards, 2) Random Discount Pack (much cheaper), 3) Themed Packs that are play-ready (or we can say "battle-proven" if they are more thoroughly tested): Beginner Pack (like New Player Welcome Pack), New Mage Pack, New Warrior Pack, Halloween Pack, etc. 4) Pick-10 (10 cards for the price of 9).
    * The game is designed that it's max fun when there are lots of different cards in possession to play with and choose from.
* During the first round, called Staging, players place the initial set of placements. A player can act always anytime there is some chance to act, unless otherwise disallowed by rules ("All things are instant"), with the only restriction that: newly played cards won't receive orders during the round they are placed. Though all other passive effects etc. can happen during the round they are placed.
* The game only ends when one of the player surrenders, or when the player has no standing army (characters) at the end of any turn (buildings don't count).
* All known effects of a card must be announced during placement.
* A player is conservative for summoning all there is due to: 1) Consideration of potentially powerful roles of other's (unplaced) cards, 2) Potential of losing it all no matter how many cards are placed, 3) Cost associated as real money, 4) Potential destruction of cards.
* The player can be considered capable of using Instant Magic through the possession and usage of Magical Effect cards (not a real classification, but defined by the following properties) that: 1) May or may not have summoning restrictions of various kinds, e.g. Resource Cards), 2) Will have an immediate effect upon placement, 3) Will have to be recalled/destroyed after placement, 4) May or may not have the restriction of the kind after usage for the whole game (e.g. can be used only once each game).
* Per time unit, there is: Turn, Round (two turns), Game (multiple rounds), Sessoon (multiple games).
* Respurce Cards are placed and kept there, accumulating for larger effects, thus strategical. All rules will include "You cannot place another (resource name) in this turn."
* Typical in-home Online play non-digital: A full setup requires a specialized device to avoid rule-bending, but otherwise besides a 图鉴 app we don't interfere with gameplay - two players will agree and make sure to entry *basic* game statistics after each game and there will be less specific awards. Or maybe we shouldn't have any such records unless a specialized hardware is used.
* Typical in-home Online play digital: Requires one or more devices connected to the (web) App. For 2-player with 3 devices, one is display, the other two are terminals to issue commands.
* Game Modes (Session/Regional Rules): 1) Restrict Library Size (this is most effective since it correlates directly to the value of cards a player has); 2) Restrict Battle Field Size. <!--We should in generally avoid restrict cards and card types: otherwise why publish those cards if you can't use it?-->
* (Proposal) Unless something has entrance effect, it enters the battlefield flipped and don't need to annouce.
* (Rule, Terminology) **Attack** = (Attack) Power - Defense. All attack will cause damage to target and self simultaneously. **Damage** = (Damage) Amount - Defense. Damage is only caused to others.
* (Rule) You will only announce effects and etc. when it's appropriate time, other wise all information can remain hidden (except being Inspected e.g. by a Scout).
* Natural defense layers can be formed through explicit **formation**: formation can be changed arbitarily during a player's turn but cannot change in opponents' turn. Changing formation conuts as one unit action. One must defeat all units in the outer layer before proceeding into later layers. Same applies to the player: for a character to initiate attack, there must be no standing units in front of it, so it must be in the outmost layer.
* Each unit can perform only one **Unit Action** per round, this include: Deployment/Placement, Change Formation (Location), Attach, Use Abilities. Passive effects don't count as unit action.

Key concepts:

* Heros: Heros usually cost the most but they are the most powerful cards on the playground. <!-- Do we actually need the distinction between creatures and heros? Certainly I won't call anything "minion" because it's demeaningful. But if the only distinction between hero and minion is heroes are more rare, and if creatures can have as many effects and skills as heros, then maybe there is no need for such. And why limit to one hero if we can have more? Maybe one practical limit would be that some Equipments can only be used by heros. -->
* Randomness: The gameplay is mostly entirely determined - with the only randomness coming from available cards in each player's library, and a player's playing order.
* Resources: All kinds of resources are available by **Resource Cards**, resource cards usually generate resources each term and they are accumulative. Unused resources are carried to the next term and wasted at the end of each game.
* Rarity: 1) Common: Everywhere, easily obtainable, can be crafted, including custom characters; 2) Uncommon: Quantity limited according to varying critieria, usually denoted as either total number (e.g. `50`), or chance of getting it in a sample pack (called "Recruit Pack"), e.g. `1 in 50`. Historical figures, special creature types, etc. 3) Rare: One of a kind with special abilities.
* Battlefield (Deprecating): Battlefield for each player has the following areas: 1) Frontline: Focus of attack/defence in a game; 2) Prison: Captured enemies; 3) Medic: On-hold units that's recovering health; 4) Graveyard: For destroyed/sacrified/consumed cards - sacrificed cards usually turn into ghost instead of being torn apart. Other areas that's outside the battlefield include: Personal library.

### Rules

A set of 2-8 players play in a predefined turn order, at each **turn**, each unit a player controls plus the player himself can take one **action**; When a player takes damage, he loses all his cards played on the **playground**. Each player can play **cards** onto **playground** from her library, which is unlimited and can be obtained in whatever method suitable as long as its legit HC cards (i.e. can borrow from other players). Each card has associated costs and attributes that deteremines how it can be placed onto battle ground and how it takes effect. At the first turn for each player, he can *place any card onto battle ground* without any *cost*. (Pending deprecation) There can be only *one* **hero card** for each game for each player at any time. <!--(Remark) This is pending deprecation since the new design of King's Cards no longer demand a hero card.-->

Newly summoned/recruited units cannot be immediately used in this turn. Abilities of any unit can be used in anyone's turn at any time - but their basic attacks can only be used during the player's turn. There is no tapping/untapping mechanism. When a player takes damage, all his cards placed on the battle ground are lost to the player that causes that damage - however, he may decide to use **Sacrifice** for supported creatures *at the time of death*, which will destroy the shell of that card but return the embedded soul card to that player's hand immediatly. One cannot decide afterwards to use sacrifice or take the sould of a card when a creature is already dead unless certain other cards have such effects.

Win/Lose Condition: 1) One player admits defeat; 2) One player has consumed all the money permitted per max bet and have no more available actions; 3) The player is defenceless (no units on the frontline and it's the other player's turn to attack). 4) Other conditions are brought up during the game. When a game ends, each player cleans its own battlefield, and claims all the loots from the common playground (mostly gold resources) and collect all loots from its prison. Notice Gold and Energy tokens can be virtual and have no physical cards; In tournaments they usually have physical exchanged real tokens for visual completeness, in ordinary games golds are just coins and energy token is usually imagined.

A unit will only level up in combat during a **kill action** - which causes death of an opponent card. In order to capture a unit instead of killing it, the commander must use the **defeat action** instead, which will save 0.5-1 hit point instead of killing it. <!--(Remark) This is to avoid a player playing with itself to level up his own cards: he can do that, if he's willing to sacrifize many cards.--> On a related note, if you are instructed to "tear down" a card, you don't really have to do that, as long as the system knows it's a destroy, the card is invalidated from the database <!--Technically this causes a transacton: a record of who killed whom is made on the records of both cards that are involved.-->. An assist doesn't count as a kill, it's not even recorded actually.

### Terminology

<!--A-->
* Attack (Action): 
* Attack Power: A unit's ability to cause damage.
<!--B-->
* Battlefield: The main playground where all active game cards goes.
<!--C-->
<!--D-->
* Defense Power: A unit's ability to avoid damage.
<!--E-->
<!--F-->
<!--G-->
* Graveyard: The place where used cards and dead units go.
<!--H-->
<!--I-->
<!--J-->
<!--K-->
<!--L-->
<!--M-->
<!--N-->
<!--O-->
<!--P-->
<!--Q-->
<!--R-->
<!--S-->
<!--T-->
<!--U-->
* Unit: Anything placed on the battlefield.
<!--V-->
<!--X-->
<!--W-->
<!--Y-->
<!--Z-->

### Cards

Classification Overview: All Army Cards, Creatures Cards and Hero Cards are Creature Cards.

Army Cards:

* Knight
    * Cost: 300
    * Print: Feirce Knight Seen In The Night.
    * Rules: 35 Health. 7 Attack. 6 Defense.
* Pawn (Unlimited)
    * Cost: 120
    * Print: 12 Health. 4 Attack. 2 Defense. This card has no additional rules.
    * Rules: 
* Scout
    * Cost: 50
    * Rules: 15 Health. 2 Attach. 0 Defence. At each **player turn**, flip one target player card.

Consumables/Items:

> Consumables can be looted.

* **Apple**: Used to regenerate health immediately.
* (Pending) **Coin**: Placement Cost 0. Equivalent as real Cost. Face value: 50. Unlimited publishing quantity. This is for ease of exchange, but can cause potential confusion. Also we might want to make explicit the measurement of "Cost", e.g. call the things put on the table as "Bet/Offer/Expense". (Deprecated) Rename "Cost" as "Placement Cost". This won't work since magic spells don't need placement.
* **Coin Token**: Used to purchase new units (place new cards).
* **Mana**: Used to use magic, cast spells and use abilities.

Monster Cards:

* Tree Monster: 55 Health. 17 Attack. 5 Defence. Prone against Fired attack (attack with fire attribute). Cost: 450. Ability: Consume 3 Mana, temporarily increase attack by 13 during this round.

Building Cards:

* **Defense Tower**: 150 Health; 15 Attack; 8 Defense. Cannot initiate attack.
* **Magic Tower**: Accumulate this to allow placement of powerful magics. Notice effect of this can be accumulative: once placed you typically won't need to remove them and you can just keep placing powerful magics. MTs don't generate Mana.
* **Work Union**: 250 Cost. 70 Health. Increase all character (Hero, Unit) cards' cost by 50; Increase all characters' Attack Power by 5.
* Small Market: Generate 25 Coin Tokens at the beginning of your turn, starting in the next round after initial placement. 150 Health. 5 Defence. Weak Against Fire (Drop defence to -15). Cost: 400.

Hero/Character Cards:

> Heros are characters with names; Usually very unique.

Magic Cards:

* Death: Cause death upon immediate member.
* Revive: Revive from graveyard.
* Prophecy: Dictate behavior of an upcoming turn (either self or other), must be permissible. Requires 2 Magical Tower present.
* Zombiefy: 
* Mummify: 
* Dodge: Escape one critical damage to a unit (the attack the might cause destruction to buildings or death to characters); Can't dodge stealing of resources.
* Reverse Time: Go back in time. Require 7 magic tower to operate. Consumes 3+N mana, where N is the number of rounds to go back to. N must be smaller or equal to 7.
* (Magic/Skill/Ability) Bargain: Recollect half the expense back to 国库/library/Vault. Cost: 0. Require 3 markets.
* (Ability/Item) Armistice agreement: Opponents cannot attack or cause damage to you for 1 round. No destructive spells can be used on you either.
* Treaty of Friendship, Alliance and Mutual Assistance: Choose one opponent to become your ally for N terms where N is the amount of money (cost) you pay to him; During this period you can win the game together. This cannot work when there is only one opponent on the battlefield.

Resource Cards: <!--Remark: Per ammendment 20211217; Instead of "generation", we just use placements restricted to one per turn to allow resource accumulation.-->

> Resources are non-destructible.

* **Apple Tree**: Generates 1 **Apple** item each player turn. Cost: 250. Don't need to annouce generation; Physical cards for apples required.
* **Mana Source/Mana Fountain**: Generates 1 **Mana** item each player turn. Unused manas can be carried to next round. Cost: 250. Don't need to annouce generation; Physical cards for apples required.

## Dated

### 20240324 Additional Game Rules

Tags: #Dream Inspired

(Was playing with Parcel, didn't get chance to organize below notes - lots of ideas below are self-contradictory and can be merged/cleaned/combined; Don't hesitate to simplify/delete some of stuff below in the future)
(TOOD: Summarize key ideas)

(Game, Experiment, Dream Inspired) 万智牌
Generate annotated HTML of plain text play through to appreciate the depths and strategies of the game with rich combinational wisdoms.
Kings Cards:
`Actor+Action [Parameters]`
Each actor is consisted of stats that's evaluated at each stage.

No complicated in-action interruption. Just round based. Key strategical element is in initial draft of known characters and guessing others draft, and having your own unique best combinations - combinations is the key. Each game have limited hands deck. No randomness or a collective randomness from both players to draw from.
Dream inspired.

Skill cards grants specific characters additional skills (1-3).
Announce: Both players can and must announce potential known effects of both players for current and next round.
在没有亮牌之前，别人是不知道具体内容、但是知道尺寸的，亮牌之后通报才能效果显形，以牌为单位。每个角色有前线（包括已经打开和没有打开的）、Supply、以及共享牌。只有前线中已经打开的牌才可以作为攻击对象。可以有“英雄”即角色本身——通过装备卡来定制。每一回合角色可以做所有当前回合每个单位可能做的动作、并且抽取一次Supply或者Shared Stack，或者翻开任意数目前线牌。前线牌限制在1-10张。的确是越多越好——这就是名副其实比手牌、比积累。完全存在那种压倒性手牌的情况——王牌游戏的关键之一就是去哪里搜集这些合规的手牌。
手牌来源包括Legends、比赛赠品、数字游戏正常获得、特殊场合获得（包括Gravity游戏）、重金购买。
游戏结束条件：如果有英雄并且英雄死亡，某方所有主动角色单位死亡。
角色技能在每一个回合内可以无限用，但是关键是可以使用的Quota往往有限制。
每一局游戏模拟的是一场现实中N小时到N天的战斗。每来回一个回合相当于一天。所有魔法和行为基本都是可以在任何人做任何事情时使用。
每一回合游戏开始前，双方可以禁止某些卡片，或者要求在Shared Stack中使用。每一回合开始时，只能中Shared Stack中或者自己的Supply中抽一张。故意前线的牌是不用打乱、并且回合开始时可以翻任意张的。
Hand模拟出阵前线。Supply模拟己方后援供应。Shared模拟战场上的随机事件，mix在一起，全部给赢家（平局的情况就直接线性平分）。Environment/BattleField模拟环境底牌，是公开的、不限数目的、留给赢家的公共资源。每一张牌在设计时会标识到底可以在哪里出现。
场上没有active手牌也算输。
Hand deck的尺寸一般都是无限的，可以玩家在游戏开始前agree，一般1-10张。环境牌、赌注牌/死牌也是如此。补给牌等数目无限但是记得需要打乱才能用，也可游戏开始前限制最多。
每一轮行动中每个角色的基础攻击一般可以无限次，但是注意攻击的时候对方也会自动反攻。如果抽补给牌则放弃一轮行动。每张可指挥角色会定义基本攻击和基本防御。攻击防御类型包括：物理魔法。进攻时会指明要进攻哪一个单位，但是对手可以立即指挥格挡单位。进攻命令不能停止。双方都没有指令则结束回合。
存在不可指挥角色，也是放在己方前线手牌中。
每一回合开始时玩家可选Take先手（可以猜拳），这个模拟了所有的defence等复杂行为。技能和主动行为只能在自己的回合操作。选择攻击是单体，没有替代防御之说。
逃跑可以带走手牌和supply。
攻击分为近身远程，前线具有简单阵列。只有第一排可以近身进攻对方第一排。防御参数完全可以通过血量来代替，物理魔法伤害也完全不必要区分。元素伤害也完全没必要区分。中毒和其他每回合自动伤害也完全没必要区分（在这种短期战场中如果有任何毒液伤害，算作立即伤害即可）。必须把前线所有士兵干掉才可以攻击英雄。英雄也是如此——必须从对方前线开始攻击。现实游戏中记录点数太麻烦——攻击时只有死或生，完全比较一个数字即Attack Point，也就是Hp，利用群攻可以增加这一数值。打完敌人后不损减。每一回合每个士兵只能进攻一次。
前线只能安排基础牌即角色牌——不能安排效果牌包括武器和魔法牌。
共享牌可以每回合抽一张，而supply牌抽一张就结束一个回合。