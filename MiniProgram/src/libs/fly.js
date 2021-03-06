/* eslint-disable */
const Fly = require('flyio/dist/npm/wx')
const fly = new Fly()
import config from '@/config'
let baseURL = config.apiHost
// const app = getApp()
//添加拦截器
fly.interceptors.request.use((request) => {
  // console.log('@9', app)
  let token = wx.getStorageSync('token')
  if (token) {
    //给所有请求添加自定义header
    request.headers['Authorization'] = `Bearer ${token}`
  }
  return request
})
fly.interceptors.response.use(
  (response) => {
    // if (typeof (response.data) === 'string' && response.data !== '') {
    //   response.data = JSON.parse(response.data)
    // }
    wx.hideLoading()
    return response.data
  },
  (err) => {
    switch(err.status) {
      case 0:
        wx.showToast({
          title: '网络错误',
          icon: 'none',
          mask: true,
          duration: 2000
        })
        break
      case 1:
        wx.showToast({
          title: '请求超时',
          icon: 'none',
          mask: true,
          duration: 2000
        })
        break
      case 500:
        wx.showToast({
          title: '服务器错误',
          mask: true,
          icon: 'none',
          duration: 3000
        })
        break
      case 403:
        wx.showToast({
          title: '请登陆',
          mask: true,
          icon: 'none',
          duration: 2000
        })
        setTimeout(()=>{
          wx.navigateTo({
            url: '/pages/login/main'
          })
        },1000)
        break
    }
    return err
  }
)
//配置请求基地址
fly.config.baseURL = baseURL
export default fly
