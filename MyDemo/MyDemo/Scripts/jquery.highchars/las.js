/**
 * 获取随机数
 * @param n 随机数位数
 * @returns {String}
 */
function RndNum(n){
	var rnd="";
	for(var i=0;i<n;i++)
		rnd+=Math.floor(Math.random()*10);
	return rnd;
}

/**
 * 数字加上，分隔
 * @param num
 * @returns {String}
 */
function commafy(num) {
	num = num + "";
	var re = /(-?\d+)(\d{3})/;
	while (re.test(num)) {
		num = num.replace(re, "$1,$2");
	}
	return num;
} 

/**
* @description 加载图的数据
* @params {String} URL 地址
* @params {Obj} 配置对象
* @params {String} 容器ID
*/
var loadChart = function(url, chartOpt, container, height, callback) {
    $.getJSON(url,
    function(data) {
        var containerId = '#' + container;
        $(containerId).empty();
        if (height == undefined) {
            height = 300;
        }
        var options = {};
        if (data.chartOptions != null) {
            options = {
                chartOptions: data.chartOptions
            };
        }
        if (data.enableLegend != null) {
            options['enableLegend'] = data.enableLegend;
        }
        options = $.extend(true, options, chartOpt);
        //如果自定义title
        if (chartOpt.title) {
            options.title = {
                text: data.title + chartOpt.title,
                useHTML: true
            };
        }
        //var isCompare = url.indexOf("need_compare=1") >= 0 ? 1 : 0;
        var _opt = {
            chartType: data.chartType || 'line',
            categories: data.categories,
            series: data.series,
            title: data.title,
            height: height,
            //isCompareSeries: isCompare,
            dataFormat: data.dataFormat || '1'
        };
        _opt = $.extend(true, _opt, options);
        $(containerId).createChart(_opt);
        //callback && callback();
    });
};
var setChart = function(data, chartOpt, container, height, callback) {
    var containerId = '#' + container;
    $(containerId).empty();
    if (height == undefined) {
        height = 300;
    }
    var options = {};
    if (data.chartOptions != null) {
        options = {
            chartOptions: data.chartOptions
        };
    }
    if (data.enableLegend != null) {
        options['enableLegend'] = data.enableLegend;
    }
    options = $.extend(true, options, chartOpt);
    //如果自定义title
    if (chartOpt.title) {
        if (data.title == undefined || data.title == null) {
            options.title = {
                text: chartOpt.title,
                useHTML: true
            };
        } else {
            options.title = {
                text: data.title + chartOpt.title,
                useHTML: true
            };
        }
    }
    var _opt = {
        chartType: data.chartType || 'line',
        categories: data.categories,
        series: data.series,
        title: data.title,
        height: height,
        isCompareSeries: 0,
        dataFormat: data.dataFormat || '1'
    };
    _opt = $.extend(true, _opt, options);
    $(containerId).createChart(_opt);
    callback && callback();
};