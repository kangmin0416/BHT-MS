import request from '@/utils/request'

export function queryProductprocess(data) {
  return request({
    url: 'api/productprocess/query',
    method: 'post',
    data
  })
}

export function getProductprocess(id) {
  return request({
    url: 'api/productprocess/get?id=' + id,
    method: 'get'
  })
}

export function getAllProductprocess(enable) {
  return request({
    url: 'api/productprocess/getAll' + (enable === undefined ? '' : ('?enable=' + enable)),
    method: 'get'
  })
}

export function createProductprocess(data) {
  return request({
    url: 'api/productprocess/create',
    method: 'post',
    data
  })
}

export function updateProductprocess(data) {
  return request({
    url: 'api/productprocess/update',
    method: 'post',
    data
  })
}

export function deleteProductprocess(id) {
  return request({
    url: 'api/productprocess/delete?id=' + id,
    method: 'get'
  })
}

export default { queryProductprocess, getProductprocess, createProductprocess, updateProductprocess, deleteProductprocess }
