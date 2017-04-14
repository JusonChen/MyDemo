using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDemo_CS
{
    public partial class trade 
    {
        //属性

        #region 数据ID标识
        /// <summary>
        /// 数据ID标识
        /// </summary>
       
        public Int32 ID { get; set; }
        #endregion

        #region 数据状态
        /// <summary>
        /// 数据状态
        /// </summary>
       
        public Int32 State { get; set; }
        #endregion

        #region 更新时间
        /// <summary>
        /// 更新时间
        /// </summary>
        
        public DateTime UpdateTime { get; set; }
        #endregion

        #region 创建时间
        /// <summary>
        /// 创建时间
        /// </summary>
        
        public DateTime CreateTime { get; set; }
        #endregion

        #region 交易编号
        /// <summary>
        /// 交易编号
        /// </summary>
        
        public Int64 tb_tid { get; set; }
        #endregion

        #region 买家昵称
        /// <summary>
        /// 买家昵称
        /// </summary>
       
        public String tb_buyer_nick { get; set; }
        #endregion

        #region 加密的昵称
        /// <summary>
        /// 加密的昵称
        /// </summary>
        
        public String EnBuyerNick { get; set; }
        #endregion

        #region 客道客户编号
        /// <summary>
        /// 客道客户编号
        /// </summary>
        
        public Int64? KdCustomerID { get; set; }
        #endregion

        #region 交易类型 
        /// <summary>
        /// 交易类型 
        /// </summary>
       
        public String tb_type { get; set; }
        #endregion

        #region 交易状态，详见pd文档
        /// <summary>
        /// 交易状态，详见pd文档
        /// </summary>
       
        public String tb_status { get; set; }
        #endregion

        #region 交易创建时间
        /// <summary>
        /// 交易创建时间
        /// </summary>
        
        public DateTime tb_created { get; set; }
        #endregion

        #region 付款时间
        /// <summary>
        /// 付款时间
        /// </summary>
       
        public DateTime? tb_pay_time { get; set; }
        #endregion

        #region 卖家发货时间
        /// <summary>
        /// 卖家发货时间
        /// </summary>
        
        public DateTime? tb_consign_time { get; set; }
        #endregion

        #region 交易成功时间
        /// <summary>
        /// 交易成功时间
        /// </summary>
        
        public DateTime? tb_end_time { get; set; }
        #endregion

        #region 超时到期时间，格式:yyyy-MM-dd HH:mm:ss。详见pd文档
        /// <summary>
        /// 超时到期时间，格式:yyyy-MM-dd HH:mm:ss。详见pd文档
        /// </summary>
        
        public DateTime? tb_timeout_action_time { get; set; }
        #endregion

        #region 买家实付金额，（单笔子订单时包含物流费用，多笔子订单时不包含物流费用 ，付款后这个价格不会变化）。精确到2位小数，单位:元。如:200.07，表示:200元7分
        /// <summary>
        /// 买家实付金额，（单笔子订单时包含物流费用，多笔子订单时不包含物流费用 ，付款后这个价格不会变化）。精确到2位小数，单位:元。如:200.07，表示:200元7分
        /// </summary>
       
        public Decimal tb_payment { get; set; }
        #endregion

        #region 商品购买数量
        /// <summary>
        /// 商品购买数量
        /// </summary>
        
        public Int32 tb_num { get; set; }
        #endregion

        #region 邮费，精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// <summary>
        /// 邮费，精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
       
        public Decimal tb_post_fee { get; set; }
        #endregion

        #region 买家留言
        /// <summary>
        /// 买家留言
        /// </summary>
       
        public String tb_buyer_message { get; set; }
        #endregion

        #region 卖家备注，（与淘宝网上订单的卖家备注对应）
        /// <summary>
        /// 卖家备注，（与淘宝网上订单的卖家备注对应）
        /// </summary>
       
        public String tb_seller_memo { get; set; }
        #endregion

        #region 卖家是否已评价，可选值:true(已评价),false(未评价)
        /// <summary>
        /// 卖家是否已评价，可选值:true(已评价),false(未评价)
        /// </summary>
        
        public bool? tb_seller_rate { get; set; }
        #endregion

        #region 买家是否已评价，可选值:true(已评价),false(未评价)
        /// <summary>
        /// 买家是否已评价，可选值:true(已评价),false(未评价)
        /// </summary>
       
        public bool? tb_buyer_rate { get; set; }
        #endregion

        #region 买家支付宝账号
        /// <summary>
        /// 买家支付宝账号
        /// </summary>
       
        public String tb_buyer_alipay_no { get; set; }
        #endregion

        #region 卖家备注旗帜，（与淘宝网上订单的卖家备注旗帜对应）
        /// <summary>
        /// 卖家备注旗帜，（与淘宝网上订单的卖家备注旗帜对应）
        /// </summary>
       
        public Int32? tb_seller_flag { get; set; }
        #endregion

        #region WAP(手机);HITAO(嗨淘);TOP(TOP平台);TAOBAO(普通淘宝);JHS(聚划算)
        /// <summary>
        /// WAP(手机);HITAO(嗨淘);TOP(TOP平台);TAOBAO(普通淘宝);JHS(聚划算)
        /// </summary>
       
        public String tb_trade_from { get; set; }
        #endregion

        #region 是否品牌特卖
        /// <summary>
        /// 是否品牌特卖
        /// </summary>
        
        public Int32? tb_isbrand_sale { get; set; }
        #endregion

        #region 分阶段付款的订单状态：FRONT_NOPAID_FINAL_NOPAID(定金未付,尾款未付) FRONT_PAID_FINAL_NOPAID(定金已付,尾款未付) FRONT_PAID_FINAL_PAID (定金已付,尾款已付)
        /// <summary>
        /// 分阶段付款的订单状态：FRONT_NOPAID_FINAL_NOPAID(定金未付,尾款未付) FRONT_PAID_FINAL_NOPAID(定金已付,尾款未付) FRONT_PAID_FINAL_PAID (定金已付,尾款已付)
        /// </summary>
        
        public String tb_step_trade_status { get; set; }
        #endregion

        #region 分阶段付款的已付金额 (万人团订单已付金额)
        /// <summary>
        /// 分阶段付款的已付金额 (万人团订单已付金额)
        /// </summary>
        
        public Decimal? tb_step_paid_fee { get; set; }
        #endregion

        #region 分阶段付款的付首款时间
        /// <summary>
        /// 分阶段付款的付首款时间
        /// </summary>
       
        public DateTime? tb_step_front_time { get; set; }
        #endregion

        #region 处方药未审核状态
        /// <summary>
        /// 处方药未审核状态
        /// </summary>
        
        public String tb_rx_audit_status { get; set; }
        #endregion

        #region 服务旺旺ID
        /// <summary>
        /// 服务旺旺ID
        /// </summary>
        
        public String kd_wwid { get; set; }
        #endregion

        #region 签收状态
        /// <summary>
        /// 签收状态
        /// </summary>
        
        public Int32? kd_receive_status { get; set; }
        #endregion

        #region 收货省份
        /// <summary>
        /// 收货省份
        /// </summary>
        
        public String kd_receive_province { get; set; }
        #endregion

        #region 收货电话
        /// <summary>
        /// 收货电话
        /// </summary>
        
        public String kd_receive_mobile { get; set; }
        #endregion

        #region 签收时间
        /// <summary>
        /// 签收时间
        /// </summary>
       
        public DateTime? kd_receive_time { get; set; }
        #endregion

        #region 揽件时间
        /// <summary>
        /// 揽件时间
        /// </summary>
       
        public DateTime? kd_got_time { get; set; }
        #endregion

        #region 发货物流公司
        /// <summary>
        /// 发货物流公司
        /// </summary>
        
        public String kd_consign_company { get; set; }
        #endregion

        #region 使用优惠券编号
        /// <summary>
        /// 使用优惠券编号
        /// </summary>
        
        public Int64? kd_coupon_number { get; set; }
        #endregion

        #region 退款金额
        /// <summary>
        /// 退款金额
        /// </summary>
       
        public Decimal kd_refund_fee { get; set; }
        #endregion

        #region 退款状态：0表示未退款
        /// <summary>
        /// 退款状态：0表示未退款
        /// </summary>
       
        public Int32 kd_refund_status { get; set; }
        #endregion

        #region 商品ID,从小到大顺序,多个‘,’隔开
        /// <summary>
        /// 商品ID,从小到大顺序,多个‘,’隔开
        /// </summary>
       
        public String union_item_id { get; set; }
        #endregion

        #region SKUID,从小到大顺序,多个‘,’隔开
        /// <summary>
        /// SKUID,从小到大顺序,多个‘,’隔开
        /// </summary>
      
        public String union_sku_id { get; set; }
        #endregion

    }
}
